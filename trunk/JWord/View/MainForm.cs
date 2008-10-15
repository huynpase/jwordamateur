using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace JWord
{
    public partial class MainForm : Form
    {
        public const int GWL_EXSTYLE = -20;
        public const int WS_EXSTYLE = -20;
        public const int WS_EX_LAYERED = 0x80000;
        public const int LWA_ALPHA = 0x2;
        public const int LWA_COLORKEY = 0x1;
        public const int TRANSPARENT = 0x20;

        [DllImport("user32.dll")]
        static extern bool SetLayeredWindowAttributes(IntPtr hwnd, uint crKey,
           byte bAlpha, uint dwFlags);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, IntPtr dwNewLong);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        List<Word> arr = null;
        int numWord = 0;
        int initAttribute = 0;

        SoundPlayer soundPlayer = new SoundPlayer();
        Dictionary<string, string> soundDict = new Dictionary<string, string>();

        public MainForm()
        {
            InitializeComponent();
            //this.initAttribute = GetWindowLong(this.Handle, GWL_EXSTYLE);
            //SetWindowLong(this.Handle, GWL_EXSTYLE, (IntPtr)(initAttribute ^ TRANSPARENT));
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            MainFormRefesh();
            //if (this.clickThrToolStripMenuItem.Checked)
            //{
            //    this.initAttribute = GetWindowLong(this.Handle, GWL_EXSTYLE);
            //    SetWindowLong(this.Handle, GWL_EXSTYLE, (IntPtr)(initAttribute ^ TRANSPARENT));
            //}
        }

        public void MainFormRefesh()
        {
            if (!Configuration.ShowKanji)
            {
                this.Height = 125 - (int)this.tableLayoutPanel1.RowStyles[0].Height - 7;
            }
            else
            {
                this.Height = 125;
            }

            // Show notification
            this.notifyIcon1.Visible = true;

            //Setup Transparent for window
            this.Opacity = Configuration.Opacity;

            SetFormLocation();
            
            //Configuration.Position = 1;
            this.tmDelay.Interval = Configuration.FreezeTime * 1000;
            this.tmDelay.Start();
            this.tmForGetMouseLocation.Interval = 100;
            this.tmForGetMouseLocation.Start();
            //Show the first word
            GetData();
            NextWord();
        }


        private void SetFormLocation()
        {
            // Setup position for window
            Rectangle desk = Screen.GetWorkingArea(this.ClientRectangle);
            Rectangle scr = Screen.GetBounds(Screen.PrimaryScreen.Bounds);
            int taskWidth = scr.Width - desk.Width;
            int taskHeight = scr.Height - desk.Height;

            switch (Configuration.Position)
            {
                case 1:
                    //Left, top Pos
                    this.Location = new Point(desk.X + Configuration.Place, desk.Y + Configuration.Place);
                    break;
                case 2:
                    //Right, Top Pos
                    this.Location = new Point(desk.X + desk.Width - this.Width - Configuration.Place, Configuration.Place + desk.Y);
                    break;
                case 3:
                    //Right, Bottom Pos
                    this.Location = new Point(desk.X + desk.Width - this.Width - Configuration.Place, desk.Y + desk.Height - this.Height - Configuration.Place);
                    break;
                default:
                    //Left, Bottom Pos
                    this.Location = new Point(desk.X + Configuration.Place, desk.Y + desk.Height - this.Height - Configuration.Place);
                    break;

            }
        }

        private void tmDelay_Tick(object sender, EventArgs e)
        {
            Delay.FadeHide(this);
            Delay.FadeShow(this);
        }
        
        public void GetData()
        {
            Database db = new Database();
            arr = db.GetWordData(GetDataType.Unstudied);
            numWord = arr.Count;
        }
        Word current = null;
        Random rd = new Random();
        public void NextWord()
        {
            if (arr.Count == 0)
                return;

            int i = rd.Next(0, numWord);
            Word w = arr[i] as Word;
            current = w;

            lblKana.Text = w.Kana;
            
            if (w.Kana.Length <= 6)
            {
                this.lblKana.Font = new Font("Tahoma", 18, FontStyle.Bold);
            }
            else if (w.Kana.Length <= 12)
            {
                this.lblKana.Font = new Font("Tahoma", 14, FontStyle.Bold);
            }
            else
            {
                this.lblKana.Font = new Font("Tahoma", 10, FontStyle.Bold);
            }

            lblKanji.Text = w.Kanji;
            
            lblMeaning.Text = w.Meaning;
            if (w.Meaning.Length <= 10)
            {
                this.lblMeaning.Font = new Font("Tahoma", 13, FontStyle.Regular);
            }
            else
            {
                this.lblMeaning.Font = new Font("Tahoma", 11, FontStyle.Regular);
            }

            int oldHeight = this.Height;

            if (string.IsNullOrEmpty( lblKanji.Text.Trim()))
            {
                this.Height = 125 - (int)this.tableLayoutPanel1.RowStyles[0].Height - 7;
            }
            else
            {
                this.Height = 125;
            }

            if (oldHeight != this.Height)
                SetFormLocation();

            this.Refresh();
        }

        #region MoveEventHandler
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.contextMenuStrip1.Show((Control)sender, e.X, e.Y);
            }
            if (!this.tmDelay.Enabled)
                this.tmDelay.Start();

            MoveHandler.MouseUp();
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            MoveHandler.MouseMove(this,e);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.tmDelay.Enabled)
                this.tmDelay.Stop();

            MoveHandler.MouseDown(e);
        }
        #endregion

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tmDelay.Stop();
            if (null != frmKanjiLearing)
                frmKanjiLearing.Dispose();
            if (null != frmData)
            {
                frmData.Activate();
                return;
            }

            frmData = new DataForm();
            frmData.parent = this;
            frmData.ShowDialog();
            frmData = null;
            this.tmDelay.Start();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.tmDelay.Stop();
            if (null != frmConfig)
            {
                frmConfig.Activate();
                return;
            }
            
            frmConfig = new ConfigForm();
            frmConfig.ParentWindow = this;
            if (null != frmKanjiLearing)
            {
                frmConfig.FrmKanjiLearing = frmKanjiLearing;
            }
            frmConfig.ShowDialog();
            frmConfig = null;
            if (null == frmKanjiLearing)
                this.tmDelay.Start();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (null != frmAbout)
            {
                frmAbout.Activate();
                return;
            }
            frmAbout = new AboutForm();
            frmAbout.ShowDialog();
            frmAbout = null;
        }

        //private void clickThrToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (!this.clickThrToolStripMenuItem.Checked)
        //    {
        //        SetWindowLong(this.Handle, GWL_EXSTYLE, (IntPtr)(initAttribute));
        //    }
        //    else
        //    {
        //        SetWindowLong(this.Handle, GWL_EXSTYLE, (IntPtr)(initAttribute ^ TRANSPARENT));
        //    }
        //    //SetLayeredWindowAttributes(this.Handle, 0, Convert.ToByte(255 * clsConfiguration.defaultOpacity), LWA_ALPHA);
        //}
        
        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            if (this.tmDelay.Enabled)
                this.tmDelay.Stop();
        }

        private void contextMenuStrip1_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            if (!this.tmDelay.Enabled)
                this.tmDelay.Start();
        }

        public void PlaySound()
        {
            if(current != null)
                SoundPlayer.Play(current.Kanji);
        }

        private void kanjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tmDelay.Stop();
            this.Opacity = 0;
            if (null != frmKanjiLearing)
            {
                frmKanjiLearing.Activate();
                return;
            }
            frmKanjiLearing = new KanjiLearning();
            frmKanjiLearing.ShowDialog();
            frmKanjiLearing = null;
            this.Opacity = Configuration.Opacity;
            this.tmDelay.Start();
        }

        private bool IsMouseEnter()
        {
            int xMouse = Control.MousePosition.X;
            int yMouse = Control.MousePosition.Y;
            
            int xMin = this.Location.X;
            int yMin = this.Location.Y;

            int xMax = xMin + this.Width;
            int yMax = yMin + this.Height;

            return ((xMin <= xMouse) && (xMouse <= xMax)) && ((yMin <= yMouse) && (yMouse <= yMax));
        }

        private void tmForGetMouseLocation_Tick(object sender, EventArgs e)
        {
            if (IsMouseEnter() && Control.ModifierKeys != Keys.Control && this.Opacity!=0)
            {
                //this.Opacity = 0;
                //Delay.FadeHide(this);
                isHideCauseMouseInter = true;
                for (float f = Configuration.Opacity; f >= 0F; f = f - 0.05F)
                {
                    this.Opacity = f;
                    System.Threading.Thread.Sleep(5);
                }
                this.Opacity = 0;
                this.tmDelay.Stop();
            }
            if (this.Opacity == 0 && (!IsMouseEnter()) && isHideCauseMouseInter)
            {
                //this.Opacity = Configuration.Opacity;
                //Delay.FadeShow(this);
                isHideCauseMouseInter = false;
                for (float f = 0.0F; f < Configuration.Opacity; f = f + 0.05F)
                {
                    this.Opacity = f;
                    System.Threading.Thread.Sleep(5);
                }
                this.Opacity = Configuration.Opacity;
                this.tmDelay.Start();
            }
            
        }

        private KanjiLearning frmKanjiLearing = null;
        private ConfigForm frmConfig = null;
        private DataForm frmData = null;
        private AboutForm frmAbout = null;
        private bool isHideCauseMouseInter = false;
    }
}