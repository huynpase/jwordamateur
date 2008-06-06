﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JWord
{
    public partial class DataForm : Form
    {
        private Word currentWord;
        private Word SelectWord
        {
            set
            {
                currentWord = value;
                FillWordIntoTextBox(this.SelectWord);
                this.btnDelete.Enabled = (this.currentWord == null) ? false : true;
            }
            get
            {
                return currentWord;
            }
        }
        public MainForm parent;
        public DataForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.GetData();
            parent.NextWord();
        }

        private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.GetData();
            parent.NextWord();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void lviWordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lviWordList.SelectedItems.Count > 0)
            {
                if (this.lviWordList.SelectedItems[0] != null &&
                    this.lviWordList.SelectedItems[0].Tag is Word)
                {
                    if (this.IsDataChanged() &&
                        MessageBox.Show("Nội dung từ đã thay đổi, bạn có muốn cập nhật không?","JWord", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Database db = new Database();
                        db.DeleteWord(this.SelectWord);
                        this.SelectWord = null;
                    }
                    else
                    {
                        this.SelectWord = this.lviWordList.SelectedItems[0].Tag as Word;
                    }
                }
            }
        }

        private void RefreshData()
        {
            ClearTextbox();
            this.lviWordList.Items.Clear();
            Database database = new Database();
            List<Word> words ;
            if (this.rdoViewAll.Checked)
            {
                words = database.GetData(GetDataType.All); 
            }
            else if (this.rdoViewUnStudied.Checked)
            {
                words = database.GetData(GetDataType.Unstudied);
            }
            else
            {
                words = database.GetData(GetDataType.Studied);
            }
            this.FillWordsIntoListView(words);
        }

        private void FillWordIntoTextBox(Word word)
        {
            if (word != null)
            {
                this.txtKana.Text = word.Kana;
                this.txtKanji.Text = word.Kanji;
                this.txtVietnamese.Text = word.Meaning;
            }
            else
            {
                this.txtKana.Text = "";
                this.txtKanji.Text = "";
                this.txtVietnamese.Text = "";
            }
        }

        private void ClearTextbox()
        {
            this.SelectWord = null;
            this.txtKana.Text = "";
            this.txtKanji.Text = "";
            this.txtVietnamese.Text = "";
        }

        private bool IsDataChanged()
        {
            if (this.SelectWord == null)
                return false;

            if (this.SelectWord.Kanji != this.txtKanji.Text ||
                this.SelectWord.Kana != this.txtKana.Text ||
                this.SelectWord.Meaning != this.txtVietnamese.Text)
                return true;

            return false;
        }

        private void FillWordsIntoListView(List<Word> words)
        {
            foreach (Word word in words)
            {
                if (word != null)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { "", word.Kanji, word.Kana, word.Meaning });
                    lvi.Checked = word.IsStudied;
                    lvi.Tag = word;
                    this.lviWordList.Items.Add(lvi);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.SelectWord != null)
            {
                Database db = new Database();
                if (db.DeleteWord(SelectWord) > 0)
                {
                    MessageBox.Show("Xóa thành công từ: " + 
                        string.Format("{0}, {1}, {2}", SelectWord.Kanji, SelectWord.Kana, SelectWord.Meaning), 
                        "JWord", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListViewItem lvi = GetListViewItemByWord(SelectWord);
                    lviWordList.Items.Remove(lvi);
                    this.SelectWord = null;
                }
            }
        }

        private void rdoViewUnStudied_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void rdoViewStudied_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void rdoViewAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void txtKanji_TextChanged(object sender, EventArgs e)
        {
            this.btnUpdate.Enabled = this.IsDataChanged();
        }

        private void txtKana_TextChanged(object sender, EventArgs e)
        {
            this.btnUpdate.Enabled = this.IsDataChanged();
        }

        private void txtVietnamese_TextChanged(object sender, EventArgs e)
        {
            this.btnUpdate.Enabled = this.IsDataChanged();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            Word temp = new Word();
            temp.Id = SelectWord.Id;
            temp.Kanji = this.txtKanji.Text;
            temp.Kana = this.txtKana.Text;
            temp.Meaning = this.txtVietnamese.Text;

            if (db.UpdateWord(temp) > 0)
            {
                ListViewItem lvi = this.GetListViewItemByWord(this.SelectWord);
                this.SelectWord = temp;
                lvi.Tag = temp;

                lvi.SubItems[0].Text = "";
                lvi.SubItems[1].Text = SelectWord.Kanji;
                lvi.SubItems[2].Text = SelectWord.Kana;
                lvi.SubItems[3].Text = SelectWord.Meaning;
            }
        }

        private ListViewItem GetListViewItemByWord(Word word)
        {
            foreach (ListViewItem lvi in lviWordList.Items)
            {
                if (lvi.Tag == this.SelectWord)
                {
                    return lvi;
                }
            }
            return null;
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            this.SelectWord = null;
        }

    }
}