namespace JWord
{
    partial class KanjiUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoKanjiUnStudied = new System.Windows.Forms.RadioButton();
            this.rdoKanjiStudied = new System.Windows.Forms.RadioButton();
            this.btnKanjiDeleleAll = new System.Windows.Forms.Button();
            this.rdoKanjiAll = new System.Windows.Forms.RadioButton();
            this.btnKanjiSetStudied = new System.Windows.Forms.Button();
            this.btnKanjiSetUnStudied = new System.Windows.Forms.Button();
            this.livKanji = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picKanjiTyping = new System.Windows.Forms.PictureBox();
            this.tbxKanjiMeaning = new System.Windows.Forms.TextBox();
            this.btnKanjiClearText = new System.Windows.Forms.Button();
            this.btnKanjiDelete = new System.Windows.Forms.Button();
            this.tbxKanji = new System.Windows.Forms.TextBox();
            this.btnKanjiUpdate = new System.Windows.Forms.Button();
            this.tbxAmOn = new System.Windows.Forms.TextBox();
            this.tbxAmKun = new System.Windows.Forms.TextBox();
            this.btnKanjiAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTipForTyping = new System.Windows.Forms.ToolTip(this.components);
            this.rtfQuickDic = new System.Windows.Forms.RichTextBox();
            this.groupBoxQuickDic = new System.Windows.Forms.GroupBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKanjiTyping)).BeginInit();
            this.groupBoxQuickDic.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.rdoKanjiUnStudied);
            this.groupBox3.Controls.Add(this.rdoKanjiStudied);
            this.groupBox3.Controls.Add(this.btnKanjiDeleleAll);
            this.groupBox3.Controls.Add(this.rdoKanjiAll);
            this.groupBox3.Controls.Add(this.btnKanjiSetStudied);
            this.groupBox3.Controls.Add(this.btnKanjiSetUnStudied);
            this.groupBox3.Location = new System.Drawing.Point(9, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(549, 83);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // rdoKanjiUnStudied
            // 
            this.rdoKanjiUnStudied.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoKanjiUnStudied.AutoSize = true;
            this.rdoKanjiUnStudied.Checked = true;
            this.rdoKanjiUnStudied.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rdoKanjiUnStudied.Location = new System.Drawing.Point(123, 19);
            this.rdoKanjiUnStudied.Name = "rdoKanjiUnStudied";
            this.rdoKanjiUnStudied.Size = new System.Drawing.Size(121, 17);
            this.rdoKanjiUnStudied.TabIndex = 10;
            this.rdoKanjiUnStudied.TabStop = true;
            this.rdoKanjiUnStudied.Text = "Hiển thị từ chưa học";
            this.rdoKanjiUnStudied.UseVisualStyleBackColor = true;
            this.rdoKanjiUnStudied.CheckedChanged += new System.EventHandler(this.rdoKanjiUnStudied_CheckedChanged);
            // 
            // rdoKanjiStudied
            // 
            this.rdoKanjiStudied.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoKanjiStudied.AutoSize = true;
            this.rdoKanjiStudied.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rdoKanjiStudied.Location = new System.Drawing.Point(250, 19);
            this.rdoKanjiStudied.Name = "rdoKanjiStudied";
            this.rdoKanjiStudied.Size = new System.Drawing.Size(110, 17);
            this.rdoKanjiStudied.TabIndex = 10;
            this.rdoKanjiStudied.TabStop = true;
            this.rdoKanjiStudied.Text = "Hiển thị từ đã học";
            this.rdoKanjiStudied.UseVisualStyleBackColor = true;
            this.rdoKanjiStudied.CheckedChanged += new System.EventHandler(this.rdoKanjiStudied_CheckedChanged);
            // 
            // btnKanjiDeleleAll
            // 
            this.btnKanjiDeleleAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKanjiDeleleAll.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnKanjiDeleleAll.Location = new System.Drawing.Point(384, 46);
            this.btnKanjiDeleleAll.Name = "btnKanjiDeleleAll";
            this.btnKanjiDeleleAll.Size = new System.Drawing.Size(102, 23);
            this.btnKanjiDeleleAll.TabIndex = 9;
            this.btnKanjiDeleleAll.Text = "Xóa";
            this.btnKanjiDeleleAll.UseVisualStyleBackColor = true;
            this.btnKanjiDeleleAll.Click += new System.EventHandler(this.btnKanjiDeleleAll_Click);
            // 
            // rdoKanjiAll
            // 
            this.rdoKanjiAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rdoKanjiAll.AutoSize = true;
            this.rdoKanjiAll.ImeMode = System.Windows.Forms.ImeMode.On;
            this.rdoKanjiAll.Location = new System.Drawing.Point(366, 19);
            this.rdoKanjiAll.Name = "rdoKanjiAll";
            this.rdoKanjiAll.Size = new System.Drawing.Size(124, 17);
            this.rdoKanjiAll.TabIndex = 10;
            this.rdoKanjiAll.TabStop = true;
            this.rdoKanjiAll.Text = "Hiển thị tất cả các từ";
            this.rdoKanjiAll.UseVisualStyleBackColor = true;
            this.rdoKanjiAll.CheckedChanged += new System.EventHandler(this.rdoKanjiAll_CheckedChanged);
            // 
            // btnKanjiSetStudied
            // 
            this.btnKanjiSetStudied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKanjiSetStudied.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnKanjiSetStudied.Location = new System.Drawing.Point(253, 46);
            this.btnKanjiSetStudied.Name = "btnKanjiSetStudied";
            this.btnKanjiSetStudied.Size = new System.Drawing.Size(102, 23);
            this.btnKanjiSetStudied.TabIndex = 8;
            this.btnKanjiSetStudied.Text = "Đặt Đã học";
            this.btnKanjiSetStudied.UseVisualStyleBackColor = true;
            this.btnKanjiSetStudied.Click += new System.EventHandler(this.btnKanjiSetStudied_Click);
            // 
            // btnKanjiSetUnStudied
            // 
            this.btnKanjiSetUnStudied.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnKanjiSetUnStudied.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnKanjiSetUnStudied.Location = new System.Drawing.Point(123, 46);
            this.btnKanjiSetUnStudied.Name = "btnKanjiSetUnStudied";
            this.btnKanjiSetUnStudied.Size = new System.Drawing.Size(102, 23);
            this.btnKanjiSetUnStudied.TabIndex = 7;
            this.btnKanjiSetUnStudied.Text = "Đặt Chưa học";
            this.btnKanjiSetUnStudied.UseVisualStyleBackColor = true;
            this.btnKanjiSetUnStudied.Click += new System.EventHandler(this.btnKanjiSetUnStudied_Click);
            // 
            // livKanji
            // 
            this.livKanji.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.livKanji.AutoArrange = false;
            this.livKanji.CausesValidation = false;
            this.livKanji.CheckBoxes = true;
            this.livKanji.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader9,
            this.columnHeader7,
            this.columnHeader8});
            this.livKanji.FullRowSelect = true;
            this.livKanji.GridLines = true;
            this.livKanji.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.livKanji.Location = new System.Drawing.Point(9, 7);
            this.livKanji.Name = "livKanji";
            this.livKanji.Size = new System.Drawing.Size(549, 188);
            this.livKanji.TabIndex = 22;
            this.livKanji.UseCompatibleStateImageBehavior = false;
            this.livKanji.View = System.Windows.Forms.View.Details;
            this.livKanji.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.livKanji_ItemChecked);
            this.livKanji.SelectedIndexChanged += new System.EventHandler(this.livKanji_SelectedIndexChanged);
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Đã học";
            this.columnHeader5.Width = 58;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 0;
            this.columnHeader6.Text = "Kanji";
            this.columnHeader6.Width = 103;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 1;
            this.columnHeader9.Text = "Onyomi";
            this.columnHeader9.Width = 106;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 2;
            this.columnHeader7.Text = "Kunyomi";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 102;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 3;
            this.columnHeader8.Text = "Tiếng Việt";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 166;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.picKanjiTyping);
            this.groupBox4.Controls.Add(this.tbxKanjiMeaning);
            this.groupBox4.Controls.Add(this.btnKanjiClearText);
            this.groupBox4.Controls.Add(this.btnKanjiDelete);
            this.groupBox4.Controls.Add(this.tbxKanji);
            this.groupBox4.Controls.Add(this.btnKanjiUpdate);
            this.groupBox4.Controls.Add(this.tbxAmOn);
            this.groupBox4.Controls.Add(this.tbxAmKun);
            this.groupBox4.Controls.Add(this.btnKanjiAdd);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(9, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(225, 198);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Quản lý từ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kunyomi";
            // 
            // picKanjiTyping
            // 
            this.picKanjiTyping.Image = global::JWord.Properties.Resources.vi;
            this.picKanjiTyping.ImeMode = System.Windows.Forms.ImeMode.On;
            this.picKanjiTyping.Location = new System.Drawing.Point(194, 96);
            this.picKanjiTyping.Name = "picKanjiTyping";
            this.picKanjiTyping.Size = new System.Drawing.Size(17, 17);
            this.picKanjiTyping.TabIndex = 7;
            this.picKanjiTyping.TabStop = false;
            this.toolTipForTyping.SetToolTip(this.picKanjiTyping, "Kiểu gõ bàn phím (Ctrl + Shift)");
            this.picKanjiTyping.Click += new System.EventHandler(this.picKanjiTyping_Click);
            // 
            // tbxKanjiMeaning
            // 
            this.tbxKanjiMeaning.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tbxKanjiMeaning.Location = new System.Drawing.Point(67, 95);
            this.tbxKanjiMeaning.Name = "tbxKanjiMeaning";
            this.tbxKanjiMeaning.Size = new System.Drawing.Size(121, 20);
            this.tbxKanjiMeaning.TabIndex = 2;
            this.tbxKanjiMeaning.TextChanged += new System.EventHandler(this.tbxKanji_TextChanged);
            this.tbxKanjiMeaning.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxKanjiMeaning_KeyDown);
            // 
            // btnKanjiClearText
            // 
            this.btnKanjiClearText.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnKanjiClearText.Location = new System.Drawing.Point(102, 130);
            this.btnKanjiClearText.Name = "btnKanjiClearText";
            this.btnKanjiClearText.Size = new System.Drawing.Size(87, 23);
            this.btnKanjiClearText.TabIndex = 3;
            this.btnKanjiClearText.Text = "Xóa Te&xt";
            this.btnKanjiClearText.UseVisualStyleBackColor = true;
            this.btnKanjiClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // btnKanjiDelete
            // 
            this.btnKanjiDelete.Enabled = false;
            this.btnKanjiDelete.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnKanjiDelete.Location = new System.Drawing.Point(9, 159);
            this.btnKanjiDelete.Name = "btnKanjiDelete";
            this.btnKanjiDelete.Size = new System.Drawing.Size(87, 23);
            this.btnKanjiDelete.TabIndex = 6;
            this.btnKanjiDelete.Text = "&Xóa";
            this.btnKanjiDelete.UseVisualStyleBackColor = true;
            this.btnKanjiDelete.Click += new System.EventHandler(this.btnKanjiDelete_Click);
            // 
            // tbxKanji
            // 
            this.tbxKanji.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbxKanji.Location = new System.Drawing.Point(67, 17);
            this.tbxKanji.Name = "tbxKanji";
            this.tbxKanji.Size = new System.Drawing.Size(121, 20);
            this.tbxKanji.TabIndex = 0;
            this.tbxKanji.TextChanged += new System.EventHandler(this.tbxKanji_TextChanged);
            // 
            // btnKanjiUpdate
            // 
            this.btnKanjiUpdate.Enabled = false;
            this.btnKanjiUpdate.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnKanjiUpdate.Location = new System.Drawing.Point(9, 130);
            this.btnKanjiUpdate.Name = "btnKanjiUpdate";
            this.btnKanjiUpdate.Size = new System.Drawing.Size(87, 23);
            this.btnKanjiUpdate.TabIndex = 5;
            this.btnKanjiUpdate.Text = "&Cập Nhật";
            this.btnKanjiUpdate.UseVisualStyleBackColor = true;
            this.btnKanjiUpdate.Click += new System.EventHandler(this.btnKanjiUpdate_Click);
            // 
            // tbxAmOn
            // 
            this.tbxAmOn.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbxAmOn.Location = new System.Drawing.Point(67, 43);
            this.tbxAmOn.Name = "tbxAmOn";
            this.tbxAmOn.Size = new System.Drawing.Size(121, 20);
            this.tbxAmOn.TabIndex = 1;
            this.tbxAmOn.TextChanged += new System.EventHandler(this.tbxKanji_TextChanged);
            // 
            // tbxAmKun
            // 
            this.tbxAmKun.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbxAmKun.Location = new System.Drawing.Point(67, 69);
            this.tbxAmKun.Name = "tbxAmKun";
            this.tbxAmKun.Size = new System.Drawing.Size(121, 20);
            this.tbxAmKun.TabIndex = 10;
            // 
            // btnKanjiAdd
            // 
            this.btnKanjiAdd.Enabled = false;
            this.btnKanjiAdd.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnKanjiAdd.Location = new System.Drawing.Point(102, 159);
            this.btnKanjiAdd.Name = "btnKanjiAdd";
            this.btnKanjiAdd.Size = new System.Drawing.Size(87, 23);
            this.btnKanjiAdd.TabIndex = 4;
            this.btnKanjiAdd.Text = "&Thêm Mới";
            this.btnKanjiAdd.UseVisualStyleBackColor = true;
            this.btnKanjiAdd.Click += new System.EventHandler(this.btnKanjiAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kanji";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label5.Location = new System.Drawing.Point(6, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tiếng Việt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label6.Location = new System.Drawing.Point(6, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Onyomi";
            // 
            // rtfQuickDic
            // 
            this.rtfQuickDic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfQuickDic.Location = new System.Drawing.Point(8, 20);
            this.rtfQuickDic.Name = "rtfQuickDic";
            this.rtfQuickDic.Size = new System.Drawing.Size(295, 166);
            this.rtfQuickDic.TabIndex = 0;
            this.rtfQuickDic.Text = "";
            // 
            // groupBoxQuickDic
            // 
            this.groupBoxQuickDic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxQuickDic.Controls.Add(this.rtfQuickDic);
            this.groupBoxQuickDic.Location = new System.Drawing.Point(249, 290);
            this.groupBoxQuickDic.Name = "groupBoxQuickDic";
            this.groupBoxQuickDic.Size = new System.Drawing.Size(309, 198);
            this.groupBoxQuickDic.TabIndex = 26;
            this.groupBoxQuickDic.TabStop = false;
            this.groupBoxQuickDic.Text = "Từ điển tra cứu nhanh";
            // 
            // KanjiUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.groupBoxQuickDic);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.livKanji);
            this.Controls.Add(this.groupBox4);
            this.Name = "KanjiUC";
            this.Size = new System.Drawing.Size(567, 491);
            this.Load += new System.EventHandler(this.KanjiForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picKanjiTyping)).EndInit();
            this.groupBoxQuickDic.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoKanjiUnStudied;
        private System.Windows.Forms.RadioButton rdoKanjiStudied;
        private System.Windows.Forms.Button btnKanjiDeleleAll;
        private System.Windows.Forms.RadioButton rdoKanjiAll;
        private System.Windows.Forms.Button btnKanjiSetStudied;
        private System.Windows.Forms.Button btnKanjiSetUnStudied;
        private System.Windows.Forms.ListView livKanji;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbxAmKun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picKanjiTyping;
        private System.Windows.Forms.TextBox tbxKanjiMeaning;
        private System.Windows.Forms.Button btnKanjiClearText;
        private System.Windows.Forms.Button btnKanjiDelete;
        private System.Windows.Forms.TextBox tbxKanji;
        private System.Windows.Forms.Button btnKanjiUpdate;
        private System.Windows.Forms.TextBox tbxAmOn;
        private System.Windows.Forms.Button btnKanjiAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTipForTyping;
        private System.Windows.Forms.RichTextBox rtfQuickDic;
        private System.Windows.Forms.GroupBox groupBoxQuickDic;

    }
}
