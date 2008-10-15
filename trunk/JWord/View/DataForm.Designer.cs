namespace JWord
{
    partial class DataForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.lviWordList = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.txtKanji = new System.Windows.Forms.TextBox();
            this.txtVietnamese = new System.Windows.Forms.TextBox();
            this.txtKana = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.picTyping = new System.Windows.Forms.PictureBox();
            this.btnClearText = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoViewUnStudied = new System.Windows.Forms.RadioButton();
            this.rdoViewStudied = new System.Windows.Forms.RadioButton();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.rdoViewAll = new System.Windows.Forms.RadioButton();
            this.btnSetStudied = new System.Windows.Forms.Button();
            this.btnSetUnstudied = new System.Windows.Forms.Button();
            this.rtbMeaning = new System.Windows.Forms.RichTextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabWord = new System.Windows.Forms.TabPage();
            this.groupBoxQuickDic = new System.Windows.Forms.GroupBox();
            this.rtfQuickDic = new System.Windows.Forms.RichTextBox();
            this.tabKanji = new System.Windows.Forms.TabPage();
            this.kanjiUserControl = new JWord.KanjiUC();
            this.tabDic = new System.Windows.Forms.TabPage();
            this.groupBoxMeaning = new System.Windows.Forms.GroupBox();
            this.lbFindWord = new System.Windows.Forms.Label();
            this.tbxFindWord = new System.Windows.Forms.TextBox();
            this.toolTipForTyping = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTyping)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabWord.SuspendLayout();
            this.groupBoxQuickDic.SuspendLayout();
            this.tabKanji.SuspendLayout();
            this.tabDic.SuspendLayout();
            this.groupBoxMeaning.SuspendLayout();
            this.SuspendLayout();
            // 
            // lviWordList
            // 
            resources.ApplyResources(this.lviWordList, "lviWordList");
            this.lviWordList.CheckBoxes = true;
            this.lviWordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lviWordList.FullRowSelect = true;
            this.lviWordList.GridLines = true;
            this.lviWordList.Name = "lviWordList";
            this.lviWordList.UseCompatibleStateImageBehavior = false;
            this.lviWordList.View = System.Windows.Forms.View.Details;
            this.lviWordList.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.lviWordList_ItemChecked);
            this.lviWordList.SelectedIndexChanged += new System.EventHandler(this.lviWordList_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // txtKanji
            // 
            resources.ApplyResources(this.txtKanji, "txtKanji");
            this.txtKanji.Name = "txtKanji";
            this.txtKanji.TextChanged += new System.EventHandler(this.txtKanji_TextChanged);
            // 
            // txtVietnamese
            // 
            resources.ApplyResources(this.txtVietnamese, "txtVietnamese");
            this.txtVietnamese.Name = "txtVietnamese";
            this.txtVietnamese.TextChanged += new System.EventHandler(this.txtVietnamese_TextChanged);
            this.txtVietnamese.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVietnamese_KeyDown);
            // 
            // txtKana
            // 
            resources.ApplyResources(this.txtKana, "txtKana");
            this.txtKana.Name = "txtKana";
            this.txtKana.TextChanged += new System.EventHandler(this.txtKana_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.picTyping);
            this.groupBox1.Controls.Add(this.txtVietnamese);
            this.groupBox1.Controls.Add(this.btnClearText);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtKanji);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtKana);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // picTyping
            // 
            this.picTyping.Image = global::JWord.Properties.Resources.vi;
            resources.ApplyResources(this.picTyping, "picTyping");
            this.picTyping.Name = "picTyping";
            this.picTyping.TabStop = false;
            this.toolTipForTyping.SetToolTip(this.picTyping, resources.GetString("picTyping.ToolTip"));
            this.picTyping.Click += new System.EventHandler(this.picTyping_Click);
            // 
            // btnClearText
            // 
            resources.ApplyResources(this.btnClearText, "btnClearText");
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.UseVisualStyleBackColor = true;
            this.btnClearText.Click += new System.EventHandler(this.btnClearText_Click);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.rdoViewUnStudied);
            this.groupBox2.Controls.Add(this.rdoViewStudied);
            this.groupBox2.Controls.Add(this.btnDeleteAll);
            this.groupBox2.Controls.Add(this.rdoViewAll);
            this.groupBox2.Controls.Add(this.btnSetStudied);
            this.groupBox2.Controls.Add(this.btnSetUnstudied);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // rdoViewUnStudied
            // 
            resources.ApplyResources(this.rdoViewUnStudied, "rdoViewUnStudied");
            this.rdoViewUnStudied.Checked = true;
            this.rdoViewUnStudied.Name = "rdoViewUnStudied";
            this.rdoViewUnStudied.TabStop = true;
            this.rdoViewUnStudied.UseVisualStyleBackColor = true;
            this.rdoViewUnStudied.CheckedChanged += new System.EventHandler(this.rdoViewUnStudied_CheckedChanged);
            // 
            // rdoViewStudied
            // 
            resources.ApplyResources(this.rdoViewStudied, "rdoViewStudied");
            this.rdoViewStudied.Name = "rdoViewStudied";
            this.rdoViewStudied.TabStop = true;
            this.rdoViewStudied.UseVisualStyleBackColor = true;
            this.rdoViewStudied.CheckedChanged += new System.EventHandler(this.rdoViewStudied_CheckedChanged);
            // 
            // btnDeleteAll
            // 
            resources.ApplyResources(this.btnDeleteAll, "btnDeleteAll");
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // rdoViewAll
            // 
            resources.ApplyResources(this.rdoViewAll, "rdoViewAll");
            this.rdoViewAll.Name = "rdoViewAll";
            this.rdoViewAll.TabStop = true;
            this.rdoViewAll.UseVisualStyleBackColor = true;
            this.rdoViewAll.CheckedChanged += new System.EventHandler(this.rdoViewAll_CheckedChanged);
            // 
            // btnSetStudied
            // 
            resources.ApplyResources(this.btnSetStudied, "btnSetStudied");
            this.btnSetStudied.Name = "btnSetStudied";
            this.btnSetStudied.UseVisualStyleBackColor = true;
            this.btnSetStudied.Click += new System.EventHandler(this.btnSetStudied_Click);
            // 
            // btnSetUnstudied
            // 
            resources.ApplyResources(this.btnSetUnstudied, "btnSetUnstudied");
            this.btnSetUnstudied.Name = "btnSetUnstudied";
            this.btnSetUnstudied.UseVisualStyleBackColor = true;
            this.btnSetUnstudied.Click += new System.EventHandler(this.btnSetUnstudied_Click);
            // 
            // rtbMeaning
            // 
            resources.ApplyResources(this.rtbMeaning, "rtbMeaning");
            this.rtbMeaning.BackColor = System.Drawing.SystemColors.Control;
            this.rtbMeaning.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbMeaning.Name = "rtbMeaning";
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Controls.Add(this.tabWord);
            this.tabControl.Controls.Add(this.tabKanji);
            this.tabControl.Controls.Add(this.tabDic);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabWord
            // 
            this.tabWord.Controls.Add(this.groupBoxQuickDic);
            this.tabWord.Controls.Add(this.lviWordList);
            this.tabWord.Controls.Add(this.groupBox2);
            this.tabWord.Controls.Add(this.groupBox1);
            resources.ApplyResources(this.tabWord, "tabWord");
            this.tabWord.Name = "tabWord";
            this.tabWord.UseVisualStyleBackColor = true;
            // 
            // groupBoxQuickDic
            // 
            resources.ApplyResources(this.groupBoxQuickDic, "groupBoxQuickDic");
            this.groupBoxQuickDic.Controls.Add(this.rtfQuickDic);
            this.groupBoxQuickDic.Name = "groupBoxQuickDic";
            this.groupBoxQuickDic.TabStop = false;
            // 
            // rtfQuickDic
            // 
            resources.ApplyResources(this.rtfQuickDic, "rtfQuickDic");
            this.rtfQuickDic.Name = "rtfQuickDic";
            // 
            // tabKanji
            // 
            this.tabKanji.Controls.Add(this.kanjiUserControl);
            resources.ApplyResources(this.tabKanji, "tabKanji");
            this.tabKanji.Name = "tabKanji";
            this.tabKanji.UseVisualStyleBackColor = true;
            // 
            // kanjiUserControl
            // 
            resources.ApplyResources(this.kanjiUserControl, "kanjiUserControl");
            this.kanjiUserControl.BackColor = System.Drawing.Color.Transparent;
            this.kanjiUserControl.Name = "kanjiUserControl";
            // 
            // tabDic
            // 
            this.tabDic.BackColor = System.Drawing.Color.Transparent;
            this.tabDic.Controls.Add(this.groupBoxMeaning);
            this.tabDic.Controls.Add(this.lbFindWord);
            this.tabDic.Controls.Add(this.tbxFindWord);
            resources.ApplyResources(this.tabDic, "tabDic");
            this.tabDic.Name = "tabDic";
            // 
            // groupBoxMeaning
            // 
            resources.ApplyResources(this.groupBoxMeaning, "groupBoxMeaning");
            this.groupBoxMeaning.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxMeaning.Controls.Add(this.rtbMeaning);
            this.groupBoxMeaning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBoxMeaning.Name = "groupBoxMeaning";
            this.groupBoxMeaning.TabStop = false;
            // 
            // lbFindWord
            // 
            resources.ApplyResources(this.lbFindWord, "lbFindWord");
            this.lbFindWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbFindWord.Name = "lbFindWord";
            // 
            // tbxFindWord
            // 
            resources.ApplyResources(this.tbxFindWord, "tbxFindWord");
            this.tbxFindWord.Name = "tbxFindWord";
            this.tbxFindWord.TextChanged += new System.EventHandler(this.tbxFindWord_TextChanged);
            // 
            // DataForm
            // 
            this.AcceptButton = this.btnAdd;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DataForm";
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTyping)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabWord.ResumeLayout(false);
            this.groupBoxQuickDic.ResumeLayout(false);
            this.tabKanji.ResumeLayout(false);
            this.tabDic.ResumeLayout(false);
            this.tabDic.PerformLayout();
            this.groupBoxMeaning.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lviWordList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txtKanji;
        private System.Windows.Forms.TextBox txtVietnamese;
        private System.Windows.Forms.TextBox txtKana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoViewAll;
        private System.Windows.Forms.RadioButton rdoViewStudied;
        private System.Windows.Forms.RadioButton rdoViewUnStudied;
        private System.Windows.Forms.Button btnSetUnstudied;
        private System.Windows.Forms.Button btnSetStudied;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.RichTextBox rtbMeaning;
        private System.Windows.Forms.PictureBox picTyping;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabDic;
        private System.Windows.Forms.TabPage tabWord;
        private System.Windows.Forms.TabPage tabKanji;
        private System.Windows.Forms.Label lbFindWord;
        private System.Windows.Forms.TextBox tbxFindWord;
        private System.Windows.Forms.GroupBox groupBoxMeaning;
        private KanjiUC kanjiUserControl;
        private System.Windows.Forms.ToolTip toolTipForTyping;
        private System.Windows.Forms.GroupBox groupBoxQuickDic;
        private System.Windows.Forms.RichTextBox rtfQuickDic;

    }
}