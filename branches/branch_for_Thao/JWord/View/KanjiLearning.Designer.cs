namespace JWord
{
    partial class KanjiLearning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KanjiLearning));
            this.lbKunyomi = new System.Windows.Forms.Label();
            this.lbOnyomi = new System.Windows.Forms.Label();
            this.lbKanji = new System.Windows.Forms.Label();
            this.lbMeaning = new System.Windows.Forms.Label();
            this.groupDetailKanji = new System.Windows.Forms.GroupBox();
            this.panelContainImage = new System.Windows.Forms.Panel();
            this.panelWallpaper = new System.Windows.Forms.Panel();
            this.panelLockView = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picShowKanjiImg = new System.Windows.Forms.PictureBox();
            this.groupDetailKanji.SuspendLayout();
            this.panelContainImage.SuspendLayout();
            this.panelWallpaper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowKanjiImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lbKunyomi
            // 
            this.lbKunyomi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbKunyomi.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lbKunyomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKunyomi.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.lbKunyomi.Location = new System.Drawing.Point(149, 98);
            this.lbKunyomi.Name = "lbKunyomi";
            this.lbKunyomi.Size = new System.Drawing.Size(135, 45);
            this.lbKunyomi.TabIndex = 6;
            this.lbKunyomi.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbKunyomi.MouseLeave += new System.EventHandler(this.lbKunyomi_MouseLeave);
            this.lbKunyomi.Click += new System.EventHandler(this.lbKunyomi_Click);
            this.lbKunyomi.MouseHover += new System.EventHandler(this.lbKunyomi_MouseHover);
            // 
            // lbOnyomi
            // 
            this.lbOnyomi.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbOnyomi.BackColor = System.Drawing.Color.Thistle;
            this.lbOnyomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOnyomi.ForeColor = System.Drawing.Color.Thistle;
            this.lbOnyomi.Location = new System.Drawing.Point(13, 98);
            this.lbOnyomi.Name = "lbOnyomi";
            this.lbOnyomi.Size = new System.Drawing.Size(135, 45);
            this.lbOnyomi.TabIndex = 7;
            this.lbOnyomi.MouseLeave += new System.EventHandler(this.lbOnyomi_MouseLeave);
            this.lbOnyomi.Click += new System.EventHandler(this.lbOnyomi_Click);
            this.lbOnyomi.MouseHover += new System.EventHandler(this.lbOnyomi_MouseHover);
            // 
            // lbKanji
            // 
            this.lbKanji.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbKanji.BackColor = System.Drawing.Color.PeachPuff;
            this.lbKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKanji.ForeColor = System.Drawing.Color.PeachPuff;
            this.lbKanji.Location = new System.Drawing.Point(13, 20);
            this.lbKanji.Name = "lbKanji";
            this.lbKanji.Size = new System.Drawing.Size(271, 37);
            this.lbKanji.TabIndex = 5;
            this.lbKanji.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbKanji.MouseLeave += new System.EventHandler(this.lbKanji_MouseLeave);
            this.lbKanji.Click += new System.EventHandler(this.lbKanji_Click);
            this.lbKanji.MouseHover += new System.EventHandler(this.lbKanji_MouseHover);
            // 
            // lbMeaning
            // 
            this.lbMeaning.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbMeaning.BackColor = System.Drawing.Color.LightGreen;
            this.lbMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMeaning.ForeColor = System.Drawing.Color.LightGreen;
            this.lbMeaning.Location = new System.Drawing.Point(13, 58);
            this.lbMeaning.Name = "lbMeaning";
            this.lbMeaning.Size = new System.Drawing.Size(271, 39);
            this.lbMeaning.TabIndex = 4;
            this.lbMeaning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMeaning.MouseLeave += new System.EventHandler(this.lbMeaning_MouseLeave);
            this.lbMeaning.Click += new System.EventHandler(this.lbMeaning_Click);
            this.lbMeaning.MouseHover += new System.EventHandler(this.lbMeaning_MouseHover);
            // 
            // groupDetailKanji
            // 
            this.groupDetailKanji.BackColor = System.Drawing.Color.Transparent;
            this.groupDetailKanji.Controls.Add(this.lbKanji);
            this.groupDetailKanji.Controls.Add(this.lbKunyomi);
            this.groupDetailKanji.Controls.Add(this.lbMeaning);
            this.groupDetailKanji.Controls.Add(this.lbOnyomi);
            this.groupDetailKanji.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDetailKanji.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupDetailKanji.Location = new System.Drawing.Point(8, 199);
            this.groupDetailKanji.Name = "groupDetailKanji";
            this.groupDetailKanji.Size = new System.Drawing.Size(297, 152);
            this.groupDetailKanji.TabIndex = 8;
            this.groupDetailKanji.TabStop = false;
            this.groupDetailKanji.Text = "Chi tiết từ";
            // 
            // panelContainImage
            // 
            this.panelContainImage.BackColor = System.Drawing.Color.Transparent;
            this.panelContainImage.BackgroundImage = global::JWord.Properties.Resources.screen;
            this.panelContainImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelContainImage.Controls.Add(this.panelWallpaper);
            this.panelContainImage.Location = new System.Drawing.Point(41, 12);
            this.panelContainImage.Name = "panelContainImage";
            this.panelContainImage.Size = new System.Drawing.Size(233, 178);
            this.panelContainImage.TabIndex = 0;
            // 
            // panelWallpaper
            // 
            this.panelWallpaper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelWallpaper.BackColor = System.Drawing.Color.Black;
            this.panelWallpaper.Controls.Add(this.panelLockView);
            this.panelWallpaper.Controls.Add(this.picBack);
            this.panelWallpaper.Controls.Add(this.picNext);
            this.panelWallpaper.Controls.Add(this.picShowKanjiImg);
            this.panelWallpaper.Location = new System.Drawing.Point(9, 7);
            this.panelWallpaper.Name = "panelWallpaper";
            this.panelWallpaper.Size = new System.Drawing.Size(215, 123);
            this.panelWallpaper.TabIndex = 0;
            // 
            // panelLockView
            // 
            this.panelLockView.BackColor = System.Drawing.Color.White;
            this.panelLockView.BackgroundImage = global::JWord.Properties.Resources.lockView;
            this.panelLockView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelLockView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLockView.Location = new System.Drawing.Point(28, 1);
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
            this.picBack.Location = new System.Drawing.Point(3, 53);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(19, 22);
            this.picBack.TabIndex = 2;
            this.picBack.TabStop = false;
            this.picBack.MouseLeave += new System.EventHandler(this.picBack_MouseLeave);
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            this.picBack.MouseHover += new System.EventHandler(this.picBack_MouseHover);
            // 
            // picNext
            // 
            this.picNext.BackColor = System.Drawing.Color.Transparent;
            this.picNext.BackgroundImage = global::JWord.Properties.Resources.next_off;
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.ErrorImage = null;
            this.picNext.Location = new System.Drawing.Point(193, 53);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(19, 22);
            this.picNext.TabIndex = 1;
            this.picNext.TabStop = false;
            this.picNext.MouseLeave += new System.EventHandler(this.picNext_MouseLeave);
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            this.picNext.MouseHover += new System.EventHandler(this.picNext_MouseHover);
            // 
            // picShowKanjiImg
            // 
            this.picShowKanjiImg.BackColor = System.Drawing.Color.White;
            this.picShowKanjiImg.BackgroundImage = global::JWord.Properties.Resources.noimage;
            this.picShowKanjiImg.ErrorImage = null;
            this.picShowKanjiImg.InitialImage = null;
            this.picShowKanjiImg.Location = new System.Drawing.Point(28, 0);
            this.picShowKanjiImg.Name = "picShowKanjiImg";
            this.picShowKanjiImg.Size = new System.Drawing.Size(160, 120);
            this.picShowKanjiImg.TabIndex = 0;
            this.picShowKanjiImg.TabStop = false;
            // 
            // KanjiLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(314, 363);
            this.Controls.Add(this.groupDetailKanji);
            this.Controls.Add(this.panelContainImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 386);
            this.Name = "KanjiLearning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Học kanji (Hoc kanji)";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KanjiLearning_KeyUp);
            this.groupDetailKanji.ResumeLayout(false);
            this.panelContainImage.ResumeLayout(false);
            this.panelWallpaper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picShowKanjiImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainImage;
        private System.Windows.Forms.PictureBox picShowKanjiImg;
        private System.Windows.Forms.Panel panelWallpaper;
        private System.Windows.Forms.Label lbKunyomi;
        private System.Windows.Forms.Label lbOnyomi;
        private System.Windows.Forms.Label lbKanji;
        private System.Windows.Forms.Label lbMeaning;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.GroupBox groupDetailKanji;
        private System.Windows.Forms.Panel panelLockView;
    }
}