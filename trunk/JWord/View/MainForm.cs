using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;

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

        public MainForm()
        {
            InitializeComponent();
        }
        
        List<Word> arr = null;
        int numWord = 0;
        int initAttribute = 0;
        private void MainForm_Load(object sender, EventArgs e)
        {
            if (!Configuration.ShowKanji)
            {
                this.Height = this.Height - (int)this.tableLayoutPanel1.RowStyles[0].Height - 7;
            }

            // Show notification
            this.notifyIcon1.Visible = true;

            //Setup Transparent for window
            this.Opacity = Configuration.DefaultOpacity;
            this.initAttribute = GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, (IntPtr)(initAttribute ^ TRANSPARENT));

            // Setup position for window
            Rectangle desk = Screen.GetWorkingArea(this.ClientRectangle);
            Rectangle scr = Screen.GetBounds(Screen.PrimaryScreen.Bounds);
            int taskWidth = scr.Width - desk.Width;
            int taskHeight = scr.Height - desk.Height;

            switch(Configuration.Position)
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

            this.tmDelay.Interval = Configuration.FreezeTime * 1000;
            this.tmDelay.Start();

            //Show the first word
            GetData();
            NextWord();
            
        }

        private void tmDelay_Tick(object sender, EventArgs e)
        {
            Delay.FadeHide(this);
            Delay.FadeShow(this);
        }
        
        public void GetData()
        {
            Database db = new Database();
            arr = db.GetData(GetDataType.Unstudied);
            numWord = arr.Count;
        }

        Random rd = new Random();
        public void NextWord()
        {
            int i = rd.Next(0, numWord);
            Word w = arr[i] as Word;

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
            
            this.Refresh();
            lblMeaning.Text = w.Meaning;
            if (w.Meaning.Length <= 10)
            {
                this.lblMeaning.Font = new Font("Tahoma", 13, FontStyle.Regular);
            }
            else
            {
                this.lblMeaning.Font = new Font("Tahoma", 11, FontStyle.Regular);
            }
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
            DataForm frm = new DataForm();
            frm.parent = this;
            frm.ShowDialog();
            this.tmDelay.Start();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            AboutForm frmAbout = new AboutForm();
            frmAbout.ShowDialog();
        }

        private void clickThrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.clickThrToolStripMenuItem.Checked)
            {
                SetWindowLong(this.Handle, GWL_EXSTYLE, (IntPtr)(initAttribute));
            }
            else
            {
                SetWindowLong(this.Handle, GWL_EXSTYLE, (IntPtr)(initAttribute ^ TRANSPARENT));
            }
            //SetLayeredWindowAttributes(this.Handle, 0, Convert.ToByte(255 * clsConfiguration.defaultOpacity), LWA_ALPHA);
        }

        private void notifyIcon1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {

        }

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
    }
}