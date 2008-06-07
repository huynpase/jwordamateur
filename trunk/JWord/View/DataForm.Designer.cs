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
            this.btnClearText = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdoViewUnStudied = new System.Windows.Forms.RadioButton();
            this.rdoViewStudied = new System.Windows.Forms.RadioButton();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.rdoViewAll = new System.Windows.Forms.RadioButton();
            this.btnSetStudied = new System.Windows.Forms.Button();
            this.btnSetUnstudied = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rdoViewUnStudied);
            this.groupBox2.Controls.Add(this.rdoViewStudied);
            this.groupBox2.Controls.Add(this.btnDeleteAll);
            this.groupBox2.Controls.Add(this.rdoViewAll);
            this.groupBox2.Controls.Add(this.btnSetStudied);
            this.groupBox2.Controls.Add(this.btnSetUnstudied);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            // 
            // btnSetUnstudied
            // 
            resources.ApplyResources(this.btnSetUnstudied, "btnSetUnstudied");
            this.btnSetUnstudied.Name = "btnSetUnstudied";
            this.btnSetUnstudied.UseVisualStyleBackColor = true;
            // 
            // DataForm
            // 
            this.AcceptButton = this.btnAdd;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lviWordList);
            this.Name = "DataForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DataForm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearText;

    }
}