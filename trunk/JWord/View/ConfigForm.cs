using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JWord
{
    public partial class ConfigForm : Form
    {
        private MainForm parentWindow;

        public MainForm ParentWindow
        {
            get { return parentWindow; }
            set { parentWindow = value; }
        }

        private Dictionary<LocationType, PictureBox> listPictureBox = new Dictionary<LocationType, PictureBox>();

        private LocationType currentLocation;

        private Image imageDemo = global::JWord.Properties.Resources.jwordDemo;

        public ConfigForm()
        {
            InitializeComponent();
            listPictureBox.Add(LocationType.BottomLeft, this.picDemoLeftBottom);
            listPictureBox.Add(LocationType.BottonRight, this.picDemoRightBottom);
            listPictureBox.Add(LocationType.TopLeft, this.picDemoLeftTop);
            listPictureBox.Add(LocationType.TopRight, this.picDemoRightTop);
            InitInfo();
            btnApply.Enabled = false;
        }

        /// <summary>
        /// CheckedChanged handle on rdoLeftTop
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void RdoLeftTop_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoLeftTop.Checked)
                ShowPictureDemo(LocationType.TopLeft);
        }

        /// <summary>
        /// CheckedChanged handle on rdoRightTop
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void RdoRightTop_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
            if (rdoRightTop.Checked)
                ShowPictureDemo(LocationType.TopRight);
        }

        /// <summary>
        /// CheckedChanged handle on rdoRightBottom
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void RdoRightBottom_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
            if (rdoRightBottom.Checked)
                ShowPictureDemo(LocationType.BottonRight);
        }

        /// <summary>
        /// CheckedChanged handle on rdoLeftBottom
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void RdoLeftBottom_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
            if (rdoLeftBottom.Checked)
                ShowPictureDemo(LocationType.BottomLeft);
        }

        /// <summary>
        /// Scroll handle on trackBarOpacity
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void TrackBarOpacity_Scroll(object sender, EventArgs e)
        {
            btnApply.Enabled = true;

            tbxOpacityValue.Text = trackBarOpacity.Value.ToString() + "%";


            float opacity = trackBarOpacity.Value / 100f;
            listPictureBox[currentLocation].Image = ImageOpacity.SetImgOpacity(imageDemo, opacity);
        }

        /// <summary>
        /// Click handle on btnOk
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            Configuration.Position = (int)currentLocation;
            Configuration.Config.Pos = Configuration.Position;
            Configuration.Opacity = (trackBarOpacity.Value / 100f);
            Configuration.Config.Opacity = Configuration.Opacity;
            Configuration.FreezeTime = (int)numUpdownTime.Value;
            Configuration.Config.FreezeTime = Configuration.FreezeTime;
            Configuration.ShowKanji = rboShowKanjiYes.Checked;
            Configuration.Config.ShowKanji = Configuration.ShowKanji;
            Configuration.Config.Save();
            parentWindow.MainFormRefesh();
            btnApply.Enabled = false;
        }

        /// <summary>
        /// ValueChanged handle on numUpdownTime
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void numUpdownTime_ValueChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        /// <summary>
        /// CheckedChanged handle on rboShowKanjiYes
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void rboShowKanjiYes_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }
        /// <summary>
        /// CheckedChanged handle on rboShowKanjiNo
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void rboShowKanjiNo_CheckedChanged(object sender, EventArgs e)
        {
            btnApply.Enabled = true;
        }

        /// <summary>
        /// Click handle on btnApply
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void btnApply_Click(object sender, EventArgs e)
        {
            BtnOk_Click(sender, e);
            parentWindow.TmDelay.Stop();
        }

        /// <summary>
        /// Closing handle on ConfigForm
        /// </summary>
        /// <param name="sender">source</param>
        /// <param name="e">event</param>
        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentWindow.TmDelay.Start();
        }


        /// <summary>
        /// Show demo image for application location.
        /// </summary>
        /// <param name="location">location of application on screen</param>
        private void ShowPictureDemo(LocationType location)
        {
            float opacity = trackBarOpacity.Value / 100f;
            currentLocation = location;
            picDemoLeftBottom.Visible = (location == LocationType.BottomLeft);
            picDemoLeftTop.Visible = (location == LocationType.TopLeft);
            picDemoRightBottom.Visible = (location == LocationType.BottonRight);
            picDemoRightTop.Visible = (location == LocationType.TopRight);
            listPictureBox[currentLocation].Image = ImageOpacity.SetImgOpacity(imageDemo, opacity);
        }

        /// <summary>
        /// Set information for config form
        /// </summary>
        private void InitInfo()
        {
            currentLocation = (LocationType)Configuration.Position;
            InitOpacity((int)(Configuration.Opacity * 100));
            ShowPictureDemo(currentLocation);
            InitRdo(currentLocation);
            numUpdownTime.Value = (decimal)Configuration.FreezeTime;
            InitShowKanji(Configuration.ShowKanji);

        }

        /// <summary>
        /// Set status for location radio button.
        /// </summary>
        /// <param name="location">location of application on screen</param>
        private void InitRdo(LocationType location)
        {
            rdoLeftBottom.Checked = (location == LocationType.BottomLeft);
            rdoLeftTop.Checked = (location == LocationType.TopLeft);
            rdoRightBottom.Checked = (location == LocationType.BottonRight);
            rdoRightTop.Checked = (location == LocationType.TopRight);
        }

        /// <summary>
        /// Initial opacity value for opacity textbox and opacity trackbar
        /// </summary>
        /// <param name="opacity"></param>
        private void InitOpacity(int opacity)
        {
            trackBarOpacity.Value = opacity;
            tbxOpacityValue.Text = trackBarOpacity.Value.ToString() + "%";
        }

        /// <summary>
        /// Set status for showkanji radio button.
        /// </summary>
        /// <param name="isShowKanji">true if show kanji or false if not show</param>
        private void InitShowKanji(bool isShowKanji)
        {
            rboShowKanjiYes.Checked = isShowKanji;
            rboShowKanjiNo.Checked = (!isShowKanji);
        }

    }
}
