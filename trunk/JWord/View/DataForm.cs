using System;
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
                    this.currentWord = this.lviWordList.SelectedItems[0].Tag as Word;
                }
            }

            // View word
            if (this.currentWord != null)
            {
                FillWordIntoTextBox(this.currentWord);
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
            this.txtKana.Text = word.Kana;
            this.txtKanji.Text = word.Kanji;
            this.txtVietnamese.Text = word.Meaning;
        }

        private void ClearTextbox()
        {
            this.currentWord = null;
            this.txtKana.Text = "";
            this.txtKanji.Text = "";
            this.txtVietnamese.Text = "";
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
            if (this.currentWord != null)
            {
                Database db = new Database();
                db.DeleteWord(currentWord);
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
    }
}