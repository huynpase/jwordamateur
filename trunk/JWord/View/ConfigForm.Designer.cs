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
            this.trackBarOpacity = new System.Windows.Forms.TrackBar();
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
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpdownTime)).BeginInit();
            this.groupDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoRightBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoRightTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoLeftBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDemoLeftTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScreen)).BeginInit();
            this.groupDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // trackBarOpacity
            // 
            this.trackBarOpacity.Location = new System.Drawing.Point(83, 18);
            this.trackBarOpacity.Maximum = 100;
            this.trackBarOpacity.Name = "trackBarOpacity";
            this.trackBarOpacity.Size = new System.Drawing.Size(221, 45);
            this.trackBarOpacity.TabIndex = 1;
            this.trackBarOpacity.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarOpacity.Scroll += new System.EventHandler(this.TrackBarOpacity_Scroll);
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
            this.groupDisplay.Controls.Add(this.rdoRightBottom);
            this.groupDisplay.Controls.Add(this.rdoRightTop);
            this.groupDisplay.Controls.Add(this.rdoLeftBottom);
            this.groupDisplay.Controls.Add(this.rdoLeftTop);
            this.groupDisplay.Controls.Add(this.picDemoRightBottom);
            this.groupDisplay.Controls.Add(this.picDemoRightTop);
            this.groupDisplay.Controls.Add(this.picDemoLeftBottom);
            this.groupDisplay.Controls.Add(this.picDemoLeftTop);
            this.groupDisplay.Controls.Add(this.picScreen);
            this.groupDisplay.Location = new System.Drawing.Point(12, 12);
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
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(44, 391);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(87, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "Lưu thay đổi";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(151, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(87, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupDetail
            // 
            this.groupDetail.Controls.Add(this.lbOpacity);
            this.groupDetail.Controls.Add(this.trackBarOpacity);
            this.groupDetail.Controls.Add(this.rboShowKanjiNo);
            this.groupDetail.Controls.Add(this.label1);
            this.groupDetail.Controls.Add(this.rboShowKanjiYes);
            this.groupDetail.Controls.Add(this.tbxOpacityValue);
            this.groupDetail.Controls.Add(this.lbShowKanji);
            this.groupDetail.Controls.Add(this.lbFreezeTime);
            this.groupDetail.Controls.Add(this.numUpdownTime);
            this.groupDetail.Location = new System.Drawing.Point(12, 240);
            this.groupDetail.Name = "groupDetail";
            this.groupDetail.Size = new System.Drawing.Size(359, 135);
            this.groupDetail.TabIndex = 14;
            this.groupDetail.TabStop = false;
            this.groupDetail.Text = "Chi tiết";
            // 
            // btnApply
            // 
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(255, 391);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(87, 23);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Áp dụng";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 431);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupDetail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 455);
            this.MinimumSize = new System.Drawing.Size(389, 455);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình (Cau hinh)";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpacity)).EndInit();
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarOpacity;
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


    }
}