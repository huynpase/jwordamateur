using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Net.SourceForge.Vietpad.InputMethod;

namespace JWord
{
    public partial class DataForm : Form
    {
        DictFileManager dict = null;
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
            kanjiUserControl.parent = parent;
            keyHandler = new VietKeyHandler(txtVietnamese);
            keyPressHandler = new KeyPressEventHandler(keyHandler.OnKeyPress);
        }

        private void DataForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.GetData();
            parent.NextWord();
        }

        private void DataForm_Load(object sender, EventArgs e)
        {
            kanjiUserControl.TextBoxKanji.TextChanged += new EventHandler(TextBoxKanjiInKanjiControl_TextChanged);

            dict = new DictFileManager();
            DictFileManager.OnGetMeaningComplete += new DictFileManager.GetMeaningCompleteDelegate(DictFileManager_OnGetMeaningComplete);
            dict.Init();

            RefreshData();
            InitInputMethod();
        }

        private void InitInputMethod()
        {
            txtVietnamese.KeyPress += keyPressHandler;
            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }

        void DictFileManager_OnGetMeaningComplete(GetMeaningCompleteArgs args)
        {
            RtfUtility rtfUtil = new RtfUtility();
            try
            {
                if (args.Meaning != "")
                {
                    string rtf = rtfUtil.GetRtfFromDictionaryString(args.Meaning);
                    this.rtbMeaning.Invoke(new UpdateRtfUI(UpdateRtf), rtf);
                    this.rtfQuickDic.Invoke(new UpdateRtfUI(UpdateRtf), rtf);
                    this.kanjiUserControl.RichTextQickDic.Invoke(new UpdateRtfUI(UpdateRtf), rtf);
                }
                else
                {
                    this.rtbMeaning.Rtf = rtfUtil.GetEmptyRtf();
                }
            }
            catch
            {
            }
        }
        private delegate void UpdateRtfUI(string rtfString);

        private void UpdateRtf(string rtfString)
        {
            if (isDicInDicTab)
                this.rtbMeaning.Rtf = rtfString;

            //TODO: moi them
            else if (isDicInWordTab)
                this.rtfQuickDic.Rtf = rtfString;
            else if (isDicInKanjiTab)
                kanjiUserControl.RichTextQickDic.Rtf = rtfString;

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
                        this.SelectWord.Kanji = txtKanji.Text;
                        this.SelectWord.Kanji = txtKana.Text;
                        this.SelectWord.Kanji = txtVietnamese.Text;
                        db.UpdateWord(this.SelectWord);
                        //this.SelectWord = null;
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
                words = database.GetWordData(GetDataType.All); 
            }
            else if (this.rdoViewUnStudied.Checked)
            {
                words = database.GetWordData(GetDataType.Unstudied);
            }
            else
            {
                words = database.GetWordData(GetDataType.Studied);
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
                if (null != word)
                {
                    ListViewItem lvi = new ListViewItem(new string[] { "", word.Kanji, word.Kana, word.Meaning});
                    lvi.Checked = word.IsStudied;
                    this.lviWordList.Items.Add(lvi);
                }
            }
            for (int index = 0; index < words.Count; index++)
            {
                if (null != words[index])
                {
                    lviWordList.Items[index].Tag = words[index];
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
                    //MessageBox.Show("Xóa thành công từ: " + 
                    //    string.Format("{0}, {1}, {2}", SelectWord.Kanji, SelectWord.Kana, SelectWord.Meaning), 
                    //    "JWord", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ListViewItem lvi = GetListViewItemByWord(SelectWord);
                    lviWordList.Items.Remove(lvi);
                    this.SelectWord = null;

                    RefreshToMainForm();
                }
            }
        }

        private void rdoViewUnStudied_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoViewUnStudied.Checked)
                RefreshData();
        }

        private void rdoViewStudied_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoViewStudied.Checked)
                RefreshData();
        }

        private void rdoViewAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoViewAll.Checked)
                RefreshData();
        }

        private void txtKanji_TextChanged(object sender, EventArgs e)
        {
            //TODO: Moi comment in
            isDicInWordTab = true;
            isDicInDicTab = false;
            isDicInKanjiTab = false;
            dict.StopGetMeaing();
            dict.StartGetMeaning(this.txtKanji.Text.ToLower());

            this.btnUpdate.Enabled = this.IsDataChanged();
            this.btnAdd.Enabled = this.HasData();
        }

        private void TextBoxKanjiInKanjiControl_TextChanged(object sender, EventArgs e)
        {
            isDicInWordTab = false;
            isDicInDicTab = false;
            isDicInKanjiTab = true;
            dict.StopGetMeaing();
            dict.StartGetMeaning(kanjiUserControl.TextBoxKanji.Text.ToLower());
        }

        private void tbxFindWord_TextChanged(object sender, EventArgs e)
        {
            isDicInWordTab = false;
            isDicInDicTab = true;
            isDicInKanjiTab = false;
            dict.StopGetMeaing();
            dict.StartGetMeaning(this.tbxFindWord.Text.ToLower());
        }

        private void txtKana_TextChanged(object sender, EventArgs e)
        {
            this.btnUpdate.Enabled = this.IsDataChanged();
            this.btnAdd.Enabled = this.HasData();
        }

        private void txtVietnamese_TextChanged(object sender, EventArgs e)
        {
            this.btnUpdate.Enabled = this.IsDataChanged();
            this.btnAdd.Enabled = this.HasData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!IsValidDataInput()) return;

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
                this.btnUpdate.Enabled = false;
                RefreshToMainForm();
            }
        }

        bool IsValidDataInput()
        {
            //if (string.IsNullOrEmpty(txtKana.Text.Trim()))
            //{
            //    MessageBox.Show("Bạn cần chưa nhập vào từ Kana? Xin vui lòng  nhập vào trước khi cập nhật.");
            //    txtKana.Focus();    
            //    return false;
            //}
            //if (string.IsNullOrEmpty(txtVietnamese.Text.Trim()))
            //{
            //    MessageBox.Show("Bạn cần chưa nhập vào tiếng Việt của từ này? Xin vui lòng  nhập vào trước khi cập nhật.");
            //    txtVietnamese.Focus();
            //    return false;
            //}
            return true;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidDataInput()) return;

            Word word = new Word();
            word.Kanji = this.txtKanji.Text;
            word.Kana = this.txtKana.Text;
            word.Meaning = this.txtVietnamese.Text;

            Database db = new Database();
            int i = db.InsertWord(word);

            if (i > 0)
            {
                Word insertedWord = db.GetLastWord();
                ListViewItem lvi = this.lviWordList.Items.Add(new ListViewItem(new string[] { "", word.Kanji, word.Kana, word.Meaning }));
                lvi.Tag = insertedWord;
                this.SelectWord = null;
                this.txtKanji.Focus();
                RefreshToMainForm();
            }
            else
            {
                MessageBox.Show("Thêm từ không thành công. Hãy thử lại!", "JWord", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void RefreshToMainForm()
        {
            parent.GetData();
            parent.NextWord();
        }

        private bool HasData()
        {
            return  (this.txtKanji.Text != "") || 
                    (this.txtKana.Text != "") || 
                    (this.txtVietnamese.Text != "");
        }

        private void lviWordList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            Database db = new Database();
            if (e.Item.Tag != null)
            {
                Word word = e.Item.Tag as Word;
                if (word.IsStudied != e.Item.Checked)
                {
                    word.IsStudied = e.Item.Checked;
                    db.UpdateWord(word);
                }
            }
        }

        private void btnSetUnstudied_Click(object sender, EventArgs e)
        {
            if (lviWordList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn ít nhất một từ.","JWord", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SetUnStudied();
            //System.Threading.Thread setThread = new System.Threading.Thread(SetUnStudied);
            //setThread.Priority = System.Threading.ThreadPriority.Highest;
            //setThread.Start();
        }

        private void btnSetStudied_Click(object sender, EventArgs e)
        {
            if (lviWordList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn ít nhất một từ.", "JWord", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SetStudied();
            //System.Threading.Thread setThread = new System.Threading.Thread(SetStudied);
            //setThread.Priority = System.Threading.ThreadPriority.Highest;
            //setThread.Start();
        }

        private void SetStudied()
        {
            Database db = new Database();
            foreach (ListViewItem lvi in lviWordList.SelectedItems)
            {
                if (lvi.Tag != null && lvi.Tag is Word)
                {
                    Word word = lvi.Tag as Word;
                    word.IsStudied = true;
                    if (db.UpdateWord(word) >= 1)
                    {
                        lvi.Checked = true;
                    }
                }
            }
        }

        private void SetUnStudied()
        {
            Database db = new Database();
            foreach (ListViewItem lvi in lviWordList.SelectedItems)
            {
                if (lvi.Tag != null && lvi.Tag is Word)
                {
                    Word word = lvi.Tag as Word;
                    word.IsStudied = true;
                    if (db.UpdateWord(word) >= 1)
                    {
                        lvi.Checked = false;
                    }
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (lviWordList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn ít nhất một từ.", "JWord", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Database db = new Database();

            foreach (ListViewItem lvi in lviWordList.SelectedItems)
            {
                if (lvi.Tag != null && lvi.Tag is Word)
                {
                    Word word = lvi.Tag as Word;
                    if (db.DeleteWord(word) >= 1)
                    {
                        lviWordList.Items.Remove(lvi);
                    }
                }
            }
        }

        private void picTyping_Click(object sender, EventArgs e)
        {
            isVietNamese = !isVietNamese;
            if (isVietNamese)
            {
                txtVietnamese.KeyPress += keyPressHandler;
                picTyping.Image = global::JWord.Properties.Resources.vi;
            }
            else
            {
                txtVietnamese.KeyPress -= keyPressHandler;
                picTyping.Image = global::JWord.Properties.Resources.en;
            }
        }

        private bool isVietNamese = true;
        private VietKeyHandler keyHandler;

        private KeyPressEventHandler keyPressHandler;

        //private void lviWordList_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Control && e.KeyValue == 65)
        //    {
        //        foreach (ListViewItem liv in lviWordList.Items)
        //            liv.Selected = true;
        //    }
        //}

        private void txtVietnamese_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift)
            { 
                picTyping_Click(picTyping, new EventArgs());
            }
        }

        private bool isDicInWordTab = false;
        private bool isDicInKanjiTab = false;
        private bool isDicInDicTab = false;
    }
}