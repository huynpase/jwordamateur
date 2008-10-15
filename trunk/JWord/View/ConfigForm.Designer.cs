namespace JWord
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.numUpdownTime = new System.Windows.Forms.NumericUpDown();
            this.groupDisplay = new System.Windows.Forms.GroupBox();
            this.rdoRightBottom = new System.Windows.Forms.RadioButton();
            this.rdoRightTop = new System.Windows.Forms.RadioButton();
            this.rdoLeftBottom = new System.Windows.Forms.RadioButton();
            this.rdoLeftTop = new System.Windows.Forms.RadioButton();
            this.picDemoRightBottom = new System.Windows.Forms.PictureBox();
            this.picDemoRightTop = new System.Windows.Forms.PictureBox();
            this.picDemoLeftBottom = new System.Windows.Forms.PictureBox();
            this.picDemoLeftTop = new System.Windows.Forms.PictureBox();
            this.picScreen = new System.Windows.Forms.PictureBox();
            this.tbxOpacityValue = new System.Windows.Forms.TextBox();
            this.lbOpacity = new System.Windows.Forms.Label();
            this.lbFreezeTime = new System.Windows.Forms.Label();
            this.lbShowKanji = new System.Windows.Forms.Label();
            this.rboShowKanjiYes = new System.Windows.Forms.RadioButton();
            this.rboShowKanjiNo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupDetail = new System.Windows.Forms.GroupBox();
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
            this.btnApply = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMainConfig = new System.Windows.Forms.TabPage();
            this.tabKanjiConfig = new System.Windows.Forms.TabPage();
            this.btnApplyForLearning = new System.Windows.Forms.Button();
            this.btnCancelForLearning = new System.Windows.Forms.Button();
            this.btnOKForLearning = new System.Windows.Forms.Button();
            this.groupDetailKanji = new System.Windows.Forms.GroupBox();
            this.chkShowKunyomi = new System.Windows.Forms.CheckBox();
            this.chkShowKanji = new System.Windows.Forms.CheckBox();
            this.chkShowOnyomi = new System.Windows.Forms.CheckBox();
            this.chkShowMeaning = new System.Windows.Forms.CheckBox();
            this.lbKanji = new System.Windows.Forms.Label();
            this.lbKunyomi = new System.Windows.Forms.Label();
            this.lbMeaning = new System.Windows.Forms.Label();
            this.lbOnyomi = new System.Windows.Forms.Label();
            this.panelContainImage = new System.Windows.Forms.Panel();
            this.panelWallpaper = new System.Windows.Forms.Panel();
            this.panelLockView = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picShowKanjiImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdownTime)).BeginInit();
            this.groupDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoRightBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoRightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoLeftBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoLeftTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
            this.groupDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabMainConfig.SuspendLayout();
            this.tabKanjiConfig.SuspendLayout();
            this.groupDetailKanji.SuspendLayout();
            this.panelContainImage.SuspendLayout();
            this.panelWallpaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowKanjiImg)).BeginInit();
            this.SuspendLayout();
            // 
            // numUpdownTime
            // 
            this.numUpdownTime.Location = new System.Drawing.Point(90, 64);
            this.numUpdownTime.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numUpdownTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpdownTime.Name = "numUpdownTime";
            this.numUpdownTime.Size = new System.Drawing.Size(116, 20);
            this.numUpdownTime.TabIndex = 3;
            this.numUpdownTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpdownTime.ValueChanged += new System.EventHandler(this.numUpdownTime_ValueChanged);
            // 
            // groupDisplay
            // 
            this.groupDisplay.BackColor = System.Drawing.Color.Transparent;
            this.groupDisplay.Controls.Add(this.rdoRightBottom);
            this.groupDisplay.Controls.Add(this.rdoRightTop);
            this.groupDisplay.Controls.Add(this.rdoLeftBottom);
            this.groupDisplay.Controls.Add(this.rdoLeftTop);
            this.groupDisplay.Controls.Add(this.picDemoRightBottom);
            this.groupDisplay.Controls.Add(this.picDemoRightTop);
            this.groupDisplay.Controls.Add(this.picDemoLeftBottom);
            this.groupDisplay.Controls.Add(this.picDemoLeftTop);
            this.groupDisplay.Controls.Add(this.picScreen);
            this.groupDisplay.Location = new System.Drawing.Point(12, 6);
            this.groupDisplay.Name = "groupDisplay";
            this.groupDisplay.Size = new System.Drawing.Size(359, 206);
            this.groupDisplay.TabIndex = 4;
            this.groupDisplay.TabStop = false;
            this.groupDisplay.Text = "Hiển thị";
            // 
            // rdoRightBottom
            // 
            this.rdoRightBottom.AutoSize = true;
            this.rdoRightBottom.Location = new System.Drawing.Point(209, 183);
            this.rdoRightBottom.Name = "rdoRightBottom";
            this.rdoRightBottom.Size = new System.Drawing.Size(86, 17);
            this.rdoRightBottom.TabIndex = 7;
            this.rdoRightBottom.TabStop = true;
            this.rdoRightBottom.Text = "Bottom Right";
            this.rdoRightBottom.UseVisualStyleBackColor = true;
            this.rdoRightBottom.CheckedChanged += new System.EventHandler(this.RdoRightBottom_CheckedChanged);
            // 
            // rdoRightTop
            // 
            this.rdoRightTop.AutoSize = true;
            this.rdoRightTop.Location = new System.Drawing.Point(209, 159);
            this.rdoRightTop.Name = "rdoRightTop";
            this.rdoRightTop.Size = new System.Drawing.Size(72, 17);
            this.rdoRightTop.TabIndex = 6;
            this.rdoRightTop.TabStop = true;
            this.rdoRightTop.Text = "Top Right";
            this.rdoRightTop.UseVisualStyleBackColor = true;
            this.rdoRightTop.CheckedChanged += new System.EventHandler(this.RdoRightTop_CheckedChanged);
            // 
            // rdoLeftBottom
            // 
            this.rdoLeftBottom.AutoSize = true;
            this.rdoLeftBottom.Location = new System.Drawing.Point(59, 182);
            this.rdoLeftBottom.Name = "rdoLeftBottom";
            this.rdoLeftBottom.Size = new System.Drawing.Size(79, 17);
            this.rdoLeftBottom.TabIndex = 5;
            this.rdoLeftBottom.TabStop = true;
            this.rdoLeftBottom.Text = "Bottom Left";
            this.rdoLeftBottom.UseVisualStyleBackColor = true;
            this.rdoLeftBottom.CheckedChanged += new System.EventHandler(this.RdoLeftBottom_CheckedChanged);
            // 
            // rdoLeftTop
            // 
            this.rdoLeftTop.AutoSize = true;
            this.rdoLeftTop.Location = new System.Drawing.Point(59, 159);
            this.rdoLeftTop.Name = "rdoLeftTop";
            this.rdoLeftTop.Size = new System.Drawing.Size(65, 17);
            this.rdoLeftTop.TabIndex = 4;
            this.rdoLeftTop.TabStop = true;
            this.rdoLeftTop.Text = "Top Left";
            this.rdoLeftTop.UseVisualStyleBackColor = true;
            this.rdoLeftTop.CheckedChanged += new System.EventHandler(this.RdoLeftTop_CheckedChanged);
            // 
            // picDemoRightBottom
            // 
            this.picDemoRightBottom.BackColor = System.Drawing.Color.Transparent;
            this.picDemoRightBottom.BackgroundImage = global::JWord.Properties.Resources.bgBR;
            this.picDemoRightBottom.Image = global::JWord.Properties.Resources.jwordDemo;
            this.picDemoRightBottom.Location = new System.Drawing.Point(209, 76);
            this.picDemoRightBottom.Name = "picDemoRightBottom";
            this.picDemoRightBottom.Size = new System.Drawing.Size(32, 36);
            this.picDemoRightBottom.TabIndex = 3;
            this.picDemoRightBottom.TabStop = false;
            this.picDemoRightBottom.Visible = false;
            // 
            // picDemoRightTop
            // 
            this.picDemoRightTop.BackColor = System.Drawing.Color.Transparent;
            this.picDemoRightTop.BackgroundImage = global::JWord.Properties.Resources.bgTR;
            this.picDemoRightTop.Image = global::JWord.Properties.Resources.jwordDemo;
            this.picDemoRightTop.Location = new System.Drawing.Point(209, 25);
            this.picDemoRightTop.Name = "picDemoRightTop";
            this.picDemoRightTop.Size = new System.Drawing.Size(32, 36);
            this.picDemoRightTop.TabIndex = 2;
            this.picDemoRightTop.TabStop = false;
            this.picDemoRightTop.Visible = false;
            // 
            // picDemoLeftBottom
            // 
            this.picDemoLeftBottom.BackColor = System.Drawing.Color.Transparent;
            this.picDemoLeftBottom.BackgroundImage = global::JWord.Properties.Resources.bgBL;
            this.picDemoLeftBottom.Image = global::JWord.Properties.Resources.jwordDemo;
            this.picDemoLeftBottom.Location = new System.Drawing.Point(106, 76);
            this.picDemoLeftBottom.Name = "picDemoLeftBottom";
            this.picDemoLeftBottom.Size = new System.Drawing.Size(32, 36);
            this.picDemoLeftBottom.TabIndex = 2;
            this.picDemoLeftBottom.TabStop = false;
            this.picDemoLeftBottom.Visible = false;
            // 
            // picDemoLeftTop
            // 
            this.picDemoLeftTop.BackColor = System.Drawing.Color.Transparent;
            this.picDemoLeftTop.BackgroundImage = global::JWord.Properties.Resources.bgTL;
            this.picDemoLeftTop.Image = global::JWord.Properties.Resources.jwordDemo;
            this.picDemoLeftTop.Location = new System.Drawing.Point(106, 25);
            this.picDemoLeftTop.Name = "picDemoLeftTop";
            this.picDemoLeftTop.Size = new System.Drawing.Size(32, 36);
            this.picDemoLeftTop.TabIndex = 1;
            this.picDemoLeftTop.TabStop = false;
            this.picDemoLeftTop.Visible = false;
            // 
            // picScreen
            // 
            this.picScreen.Image = global::JWord.Properties.Resources.screen;
            this.picScreen.Location = new System.Drawing.Point(98, 19);
            this.picScreen.Name = "picScreen";
            this.picScreen.Size = new System.Drawing.Size(150, 127);
            this.picScreen.TabIndex = 0;
            this.picScreen.TabStop = false;
            // 
            // tbxOpacityValue
            // 
            this.tbxOpacityValue.BackColor = System.Drawing.Color.White;
            this.tbxOpacityValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxOpacityValue.ForeColor = System.Drawing.Color.Black;
            this.tbxOpacityValue.Location = new System.Drawing.Point(309, 18);
            this.tbxOpacityValue.Name = "tbxOpacityValue";
            this.tbxOpacityValue.ReadOnly = true;
            this.tbxOpacityValue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbxOpacityValue.Size = new System.Drawing.Size(36, 20);
            this.tbxOpacityValue.TabIndex = 5;
            // 
            // lbOpacity
            // 
            this.lbOpacity.AutoSize = true;
            this.lbOpacity.Location = new System.Drawing.Point(10, 25);
            this.lbOpacity.Name = "lbOpacity";
            this.lbOpacity.Size = new System.Drawing.Size(71, 13);
            this.lbOpacity.TabIndex = 6;
            this.lbOpacity.Text = "Độ trong suốt";
            // 
            // lbFreezeTime
            // 
            this.lbFreezeTime.AutoSize = true;
            this.lbFreezeTime.Location = new System.Drawing.Point(10, 66);
            this.lbFreezeTime.Name = "lbFreezeTime";
            this.lbFreezeTime.Size = new System.Drawing.Size(66, 13);
            this.lbFreezeTime.TabIndex = 7;
            this.lbFreezeTime.Text = "Thời gian trễ";
            // 
            // lbShowKanji
            // 
            this.lbShowKanji.AutoSize = true;
            this.lbShowKanji.Location = new System.Drawing.Point(12, 104);
            this.lbShowKanji.Name = "lbShowKanji";
            this.lbShowKanji.Size = new System.Drawing.Size(69, 13);
            this.lbShowKanji.TabIndex = 8;
            this.lbShowKanji.Text = "Hiển thị Kanji";
            // 
            // rboShowKanjiYes
            // 
            this.rboShowKanjiYes.AutoSize = true;
            this.rboShowKanjiYes.Location = new System.Drawing.Point(90, 104);
            this.rboShowKanjiYes.Name = "rboShowKanjiYes";
            this.rboShowKanjiYes.Size = new System.Drawing.Size(38, 17);
            this.rboShowKanjiYes.TabIndex = 9;
            this.rboShowKanjiYes.TabStop = true;
            this.rboShowKanjiYes.Text = "Có";
            this.rboShowKanjiYes.UseVisualStyleBackColor = true;
            this.rboShowKanjiYes.CheckedChanged += new System.EventHandler(this.rboShowKanjiYes_CheckedChanged);
            // 
            // rboShowKanjiNo
            // 
            this.rboShowKanjiNo.AutoSize = true;
            this.rboShowKanjiNo.Location = new System.Drawing.Point(219, 102);
            this.rboShowKanjiNo.Name = "rboShowKanjiNo";
            this.rboShowKanjiNo.Size = new System.Drawing.Size(56, 17);
            this.rboShowKanjiNo.TabIndex = 10;
            this.rboShowKanjiNo.TabStop = true;
            this.rboShowKanjiNo.Text = "Không";
            this.rboShowKanjiNo.UseVisualStyleBackColor = true;
            this.rboShowKanjiNo.CheckedChanged += new System.EventHandler(this.rboShowKanjiNo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "(đơn vị tính bằng giây)";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.Control;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(44, 364);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Lưu thay đổi";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(151, 364);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // groupDetail
            // 
            this.groupDetail.BackColor = System.Drawing.Color.Transparent;
            this.groupDetail.Controls.Add(this.lbOpacity);
            this.groupDetail.Controls.Add(this.trackBarOpacity);
            this.groupDetail.Controls.Add(this.rboShowKanjiNo);
            this.groupDetail.Controls.Add(this.label1);
            this.groupDetail.Controls.Add(this.rboShowKanjiYes);
            this.groupDetail.Controls.Add(this.tbxOpacityValue);
            this.groupDetail.Controls.Add(this.lbShowKanji);
            this.groupDetail.Controls.Add(this.lbFreezeTime);
            this.groupDetail.Controls.Add(this.numUpdownTime);
            this.groupDetail.Location = new System.Drawing.Point(12, 218);
            this.groupDetail.Name = "groupDetail";
            this.groupDetail.Size = new System.Drawing.Size(359, 135);
            this.groupDetail.TabIndex = 14;
            this.groupDetail.TabStop = false;
            this.groupDetail.Text = "Chi tiết";
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.BackColor = System.Drawing.Color.White;
            this.trackBarOpacity.Location = new System.Drawing.Point(83, 18);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(221, 42);
            this.trackBarOpacity.TabIndex = 1;
            this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.TrackBarOpacity_Scroll);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.Control;
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(255, 364);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(87, 23);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Áp dụng";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMainConfig);
            this.tabControl1.Controls.Add(this.tabKanjiConfig);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 434);
            this.tabControl1.TabIndex = 16;
            // 
            // tabMainConfig
            // 
            this.tabMainConfig.BackColor = System.Drawing.Color.White;
            this.tabMainConfig.Controls.Add(this.groupDisplay);
            this.tabMainConfig.Controls.Add(this.btnApply);
            this.tabMainConfig.Controls.Add(this.btnCancel);
            this.tabMainConfig.Controls.Add(this.groupDetail);
            this.tabMainConfig.Controls.Add(this.btnOk);
            this.tabMainConfig.Location = new System.Drawing.Point(4, 22);
            this.tabMainConfig.Name = "tabMainConfig";
            this.tabMainConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabMainConfig.Size = new System.Drawing.Size(384, 408);
            this.tabMainConfig.TabIndex = 0;
            this.tabMainConfig.Text = "Màn hình chính     ";
            // 
            // tabKanjiConfig
            // 
            this.tabKanjiConfig.BackColor = System.Drawing.Color.White;
            this.tabKanjiConfig.Controls.Add(this.btnApplyForLearning);
            this.tabKanjiConfig.Controls.Add(this.btnCancelForLearning);
            this.tabKanjiConfig.Controls.Add(this.btnOKForLearning);
            this.tabKanjiConfig.Controls.Add(this.groupDetailKanji);
            this.tabKanjiConfig.Controls.Add(this.panelContainImage);
            this.tabKanjiConfig.Location = new System.Drawing.Point(4, 22);
            this.tabKanjiConfig.Name = "tabKanjiConfig";
            this.tabKanjiConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabKanjiConfig.Size = new System.Drawing.Size(384, 408);
            this.tabKanjiConfig.TabIndex = 1;
            this.tabKanjiConfig.Text = "Hiển thị kanji     ";
            // 
            // btnApplyForLearning
            // 
            this.btnApplyForLearning.BackColor = System.Drawing.SystemColors.Control;
            this.btnApplyForLearning.Enabled = false;
            this.btnApplyForLearning.Location = new System.Drawing.Point(255, 364);
            this.btnApplyForLearning.Name = "btnApplyForLearning";
            this.btnApplyForLearning.Size = new System.Drawing.Size(87, 23);
            this.btnApplyForLearning.TabIndex = 16;
            this.btnApplyForLearning.Text = "Áp dụng";
            this.btnApplyForLearning.UseVisualStyleBackColor = false;
            this.btnApplyForLearning.Click += new System.EventHandler(this.btnApplyForLearning_Click);
            // 
            // btnCancelForLearning
            // 
            this.btnCancelForLearning.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancelForLearning.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelForLearning.Location = new System.Drawing.Point(151, 364);
            this.btnCancelForLearning.Name = "btnCancelForLearning";
            this.btnCancelForLearning.Size = new System.Drawing.Size(87, 23);
            this.btnCancelForLearning.TabIndex = 14;
            this.btnCancelForLearning.Text = "Hủy bỏ";
            this.btnCancelForLearning.UseVisualStyleBackColor = false;
            this.btnCancelForLearning.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnOKForLearning
            // 
            this.btnOKForLearning.BackColor = System.Drawing.SystemColors.Control;
            this.btnOKForLearning.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKForLearning.Location = new System.Drawing.Point(44, 364);
            this.btnOKForLearning.Name = "btnOKForLearning";
            this.btnOKForLearning.Size = new System.Drawing.Size(87, 23);
            this.btnOKForLearning.TabIndex = 13;
            this.btnOKForLearning.Text = "Lưu thay đổi";
            this.btnOKForLearning.UseVisualStyleBackColor = false;
            this.btnOKForLearning.Click += new System.EventHandler(this.btnOKForLearning_Click);
            // 
            // groupDetailKanji
            // 
            this.groupDetailKanji.BackColor = System.Drawing.Color.Transparent;
            this.groupDetailKanji.Controls.Add(this.chkShowKunyomi);
            this.groupDetailKanji.Controls.Add(this.chkShowKanji);
            this.groupDetailKanji.Controls.Add(this.chkShowOnyomi);
            this.groupDetailKanji.Controls.Add(this.chkShowMeaning);
            this.groupDetailKanji.Controls.Add(this.lbKanji);
            this.groupDetailKanji.Controls.Add(this.lbKunyomi);
            this.groupDetailKanji.Controls.Add(this.lbMeaning);
            this.groupDetailKanji.Controls.Add(this.lbOnyomi);
            this.groupDetailKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDetailKanji.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupDetailKanji.Location = new System.Drawing.Point(12, 218);
            this.groupDetailKanji.Name = "groupDetailKanji";
            this.groupDetailKanji.Size = new System.Drawing.Size(359, 135);
            this.groupDetailKanji.TabIndex = 9;
            this.groupDetailKanji.TabStop = false;
            this.groupDetailKanji.Text = "Tùy chọn hiển thị";
            // 
            // chkShowKunyomi
            // 
            this.chkShowKunyomi.AutoSize = true;
            this.chkShowKunyomi.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.chkShowKunyomi.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkShowKunyomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowKunyomi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.chkShowKunyomi.Location = new System.Drawing.Point(205, 93);
            this.chkShowKunyomi.Name = "chkShowKunyomi";
            this.chkShowKunyomi.Size = new System.Drawing.Size(119, 19);
            this.chkShowKunyomi.TabIndex = 14;
            this.chkShowKunyomi.Text = "Hiển thị Kunyomi";
            this.chkShowKunyomi.UseVisualStyleBackColor = false;
            this.chkShowKunyomi.CheckedChanged += new System.EventHandler(this.chkShowKanji_CheckedChanged);
            // 
            // chkShowKanji
            // 
            this.chkShowKanji.AutoSize = true;
            this.chkShowKanji.BackColor = System.Drawing.Color.PeachPuff;
            this.chkShowKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowKanji.ForeColor = System.Drawing.Color.Red;
            this.chkShowKanji.Location = new System.Drawing.Point(118, 36);
            this.chkShowKanji.Name = "chkShowKanji";
            this.chkShowKanji.Size = new System.Drawing.Size(99, 19);
            this.chkShowKanji.TabIndex = 11;
            this.chkShowKanji.Text = "Hiển thị Kanji";
            this.chkShowKanji.UseVisualStyleBackColor = false;
            this.chkShowKanji.CheckedChanged += new System.EventHandler(this.chkShowKanji_CheckedChanged);
            // 
            // chkShowOnyomi
            // 
            this.chkShowOnyomi.AutoSize = true;
            this.chkShowOnyomi.BackColor = System.Drawing.Color.Thistle;
            this.chkShowOnyomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowOnyomi.ForeColor = System.Drawing.Color.Black;
            this.chkShowOnyomi.Location = new System.Drawing.Point(35, 93);
            this.chkShowOnyomi.Name = "chkShowOnyomi";
            this.chkShowOnyomi.Size = new System.Drawing.Size(113, 19);
            this.chkShowOnyomi.TabIndex = 13;
            this.chkShowOnyomi.Text = "Hiển thị Onyomi";
            this.chkShowOnyomi.UseVisualStyleBackColor = false;
            this.chkShowOnyomi.CheckedChanged += new System.EventHandler(this.chkShowKanji_CheckedChanged);
            // 
            // chkShowMeaning
            // 
            this.chkShowMeaning.AutoSize = true;
            this.chkShowMeaning.BackColor = System.Drawing.Color.LightGreen;
            this.chkShowMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowMeaning.ForeColor = System.Drawing.Color.DarkRed;
            this.chkShowMeaning.Location = new System.Drawing.Point(118, 64);
            this.chkShowMeaning.Name = "chkShowMeaning";
            this.chkShowMeaning.Size = new System.Drawing.Size(125, 19);
            this.chkShowMeaning.TabIndex = 12;
            this.chkShowMeaning.Text = "Hiển thị Tiếng Việt";
            this.chkShowMeaning.UseVisualStyleBackColor = false;
            this.chkShowMeaning.CheckedChanged += new System.EventHandler(this.chkShowMeaning_CheckedChanged);
            // 
            // lbKanji
            // 
            this.lbKanji.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbKanji.BackColor = System.Drawing.Color.PeachPuff;
            this.lbKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKanji.ForeColor = System.Drawing.Color.PeachPuff;
            this.lbKanji.Location = new System.Drawing.Point(13, 27);
            this.lbKanji.Name = "lbKanji";
            this.lbKanji.Size = new System.Drawing.Size(333, 31);
            this.lbKanji.TabIndex = 5;
            this.lbKanji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKunyomi
            // 
            this.lbKunyomi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbKunyomi.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbKunyomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKunyomi.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lbKunyomi.Location = new System.Drawing.Point(183, 89);
            this.lbKunyomi.Name = "lbKunyomi";
            this.lbKunyomi.Size = new System.Drawing.Size(163, 30);
            this.lbKunyomi.TabIndex = 6;
            this.lbKunyomi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbMeaning
            // 
            this.lbMeaning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMeaning.BackColor = System.Drawing.Color.LightGreen;
            this.lbMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMeaning.ForeColor = System.Drawing.Color.LightGreen;
            this.lbMeaning.Location = new System.Drawing.Point(13, 59);
            this.lbMeaning.Name = "lbMeaning";
            this.lbMeaning.Size = new System.Drawing.Size(333, 29);
            this.lbMeaning.TabIndex = 4;
            this.lbMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOnyomi
            // 
            this.lbOnyomi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbOnyomi.BackColor = System.Drawing.Color.Thistle;
            this.lbOnyomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOnyomi.ForeColor = System.Drawing.Color.Thistle;
            this.lbOnyomi.Location = new System.Drawing.Point(13, 89);
            this.lbOnyomi.Name = "lbOnyomi";
            this.lbOnyomi.Size = new System.Drawing.Size(168, 30);
            this.lbOnyomi.TabIndex = 7;
            // 
            // panelContainImage
            // 
            this.panelContainImage.BackColor = System.Drawing.Color.Transparent;
            this.panelContainImage.BackgroundImage = global::JWord.Properties.Resources.screen;
            this.panelContainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainImage.Controls.Add(this.panelWallpaper);
            this.panelContainImage.Location = new System.Drawing.Point(85, 11);
            this.panelContainImage.Name = "panelContainImage";
            this.panelContainImage.Size = new System.Drawing.Size(233, 178);
            this.panelContainImage.TabIndex = 10;
            // 
            // panelWallpaper
            // 
            this.panelWallpaper.BackColor = System.Drawing.Color.Black;
            this.panelWallpaper.Controls.Add(this.panelLockView);
            this.panelWallpaper.Controls.Add(this.picBack);
            this.panelWallpaper.Controls.Add(this.picNext);
            this.panelWallpaper.Controls.Add(this.picShowKanjiImg);
            this.panelWallpaper.Location = new System.Drawing.Point(10, 8);
            this.panelWallpaper.Name = "panelWallpaper";
            this.panelWallpaper.Size = new System.Drawing.Size(212, 122);
            this.panelWallpaper.TabIndex = 0;
            // 
            // panelLockView
            // 
            this.panelLockView.BackColor = System.Drawing.Color.White;
            this.panelLockView.BackgroundImage = global::JWord.Properties.Resources.lockView;
            this.panelLockView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLockView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLockView.Location = new System.Drawing.Point(28, 0);
            this.panelLockView.Name = "panelLockView";
            this.panelLockView.Size = new System.Drawing.Size(160, 120);
            this.panelLockView.TabIndex = 3;
            this.panelLockView.Click += new System.EventHandler(this.panelLockView_Click);
            // 
            // picBack
            // 
            this.picBack.BackColor = System.Drawing.Color.Transparent;
            this.picBack.BackgroundImage = global::JWord.Properties.Resources.back_off;
            this.picBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBack.ErrorImage = null;
            this.picBack.Location = new System.Drawing.Point(3, 51);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(19, 22);
            this.picBack.TabIndex = 2;
            this.picBack.TabStop = false;
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.BackgroundImage = global::JWord.Properties.Resources.next_off;
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.ErrorImage = null;
            this.picNext.Location = new System.Drawing.Point(193, 51);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(19, 22);
            this.picNext.TabIndex = 1;
            this.picNext.TabStop = false;
            // 
            // picShowKanjiImg
            // 
            this.picShowKanjiImg.BackColor = System.Drawing.Color.White;
            this.picShowKanjiImg.BackgroundImage = global::JWord.Properties.Resources.noimage;
            this.picShowKanjiImg.ErrorImage = null;
            this.picShowKanjiImg.Image = global::JWord.Properties.Resources._4E7E;
            this.picShowKanjiImg.InitialImage = null;
            this.picShowKanjiImg.Location = new System.Drawing.Point(28, 0);
            this.picShowKanjiImg.Name = "picShowKanjiImg";
            this.picShowKanjiImg.Size = new System.Drawing.Size(160, 120);
            this.picShowKanjiImg.TabIndex = 0;
            this.picShowKanjiImg.TabStop = false;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(409, 451);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(389, 455);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình (Cau hinh)";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numUpdownTime)).EndInit();
            this.groupDisplay.ResumeLayout(false);
            this.groupDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoRightBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoRightTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoLeftBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoLeftTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).EndInit();
            this.groupDetail.ResumeLayout(false);
            this.groupDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabMainConfig.ResumeLayout(false);
            this.tabKanjiConfig.ResumeLayout(false);
            this.groupDetailKanji.ResumeLayout(false);
            this.groupDetailKanji.PerformLayout();
            this.panelContainImage.ResumeLayout(false);
            this.panelWallpaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowKanjiImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numUpdownTime;
        private System.Windows.Forms.GroupBox groupDisplay;
        private System.Windows.Forms.PictureBox picScreen;
        private System.Windows.Forms.PictureBox picDemoRightBottom;
        private System.Windows.Forms.PictureBox picDemoRightTop;
        private System.Windows.Forms.PictureBox picDemoLeftBottom;
        private System.Windows.Forms.PictureBox picDemoLeftTop;
        private System.Windows.Forms.RadioButton rdoLeftBottom;
        private System.Windows.Forms.RadioButton rdoLeftTop;
        private System.Windows.Forms.RadioButton rdoRightBottom;
        private System.Windows.Forms.RadioButton rdoRightTop;
        private System.Windows.Forms.TextBox tbxOpacityValue;
        private System.Windows.Forms.Label lbOpacity;
        private System.Windows.Forms.Label lbFreezeTime;
        private System.Windows.Forms.Label lbShowKanji;
        private System.Windows.Forms.RadioButton rboShowKanjiYes;
        private System.Windows.Forms.RadioButton rboShowKanjiNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupDetail;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMainConfig;
        private System.Windows.Forms.TabPage tabKanjiConfig;
        private System.Windows.Forms.TrackBar trackBarOpacity;
        private System.Windows.Forms.GroupBox groupDetailKanji;
        private System.Windows.Forms.Label lbKanji;
        private System.Windows.Forms.Label lbKunyomi;
        private System.Windows.Forms.Label lbMeaning;
        private System.Windows.Forms.Label lbOnyomi;
        private System.Windows.Forms.CheckBox chkShowKunyomi;
        private System.Windows.Forms.CheckBox chkShowOnyomi;
        private System.Windows.Forms.CheckBox chkShowMeaning;
        private System.Windows.Forms.CheckBox chkShowKanji;
        private System.Windows.Forms.Button btnApplyForLearning;
        private System.Windows.Forms.Button btnCancelForLearning;
        private System.Windows.Forms.Button btnOKForLearning;
        private System.Windows.Forms.Panel panelContainImage;
        private System.Windows.Forms.Panel panelWallpaper;
        private System.Windows.Forms.Panel panelLockView;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picShowKanjiImg;


    }
}