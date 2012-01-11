using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Net.SourceForge.Vietpad.InputMethod;

namespace JWord
{
    public partial class KanjiUC : UserControl
    {
        public TextBox TextBoxKanji
        {
            get {return tbxKanji; }
        }
        public RichTextBox RichTextQickDic
        {
            get { return this.rtfQuickDic; }
        }

        private Kanji currentKanji;
        private Kanji SelectKanji
        {
            set
            {
                currentKanji = value;
                FillKanjiIntoTextBox(this.SelectKanji);
                this.btnKanjiDelete.Enabled = (this.currentKanji == null) ? false : true;
            }
            get
            {
                return currentKanji;
            }
        }
        public MainForm parent;

        public KanjiUC()
        {
            InitializeComponent();
            keyHandler = new VietKeyHandler(tbxKanjiMeaning);
            keyPressHandler = new KeyPressEventHandler(keyHandler.OnKeyPress);
        }
      

        private void KanjiForm_Load(object sender, EventArgs e)
        {
            InitInputMethod();
            try
            {
                RefreshData();
            }
            catch { } 
        }

        private void InitInputMethod()
        {
            tbxKanjiMeaning.KeyPress += keyPressHandler;
            VietKeyHandler.InputMethod = InputMethods.Telex;
            VietKeyHandler.VietModeEnabled = true;
            VietKeyHandler.SmartMark = true;
        }

        private void livKanji_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.livKanji.SelectedItems.Count > 0)
            {
                if (this.livKanji.SelectedItems[0] != null &&
                    this.livKanji.SelectedItems[0].Tag is Kanji)
                {
                    if (this.IsDataChanged() &&
                        MessageBox.Show("Nội dung từ đã thay đổi, bạn có muốn cập nhật không?","JWord", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Database db = new Database();
                        SelectKanji.StrKanji = this.tbxKanji.Text;
                        SelectKanji.StrAmon = this.tbxAmOn.Text;
                        SelectKanji.StrAmkun = this.tbxAmKun.Text;
                        SelectKanji.StrMeaning = this.tbxKanjiMeaning.Text;
                        db.UpdateKanji(SelectKanji);
                        RefreshData();                        
                    }
                    else
                    {
                        this.SelectKanji = this.livKanji.SelectedItems[0].Tag as Kanji;
                    }
                }
            }
        }

        private void RefreshData()
        {
            ClearTextbox();
            this.livKanji.Items.Clear();
            Database database = new Database();
            List<Kanji> kanjis ;
            if (this.rdoKanjiAll.Checked)
            {
                kanjis = database.GetKanjiData(GetDataType.All); 
            }
            else if (this.rdoKanjiUnStudied.Checked)
            {
                kanjis = database.GetKanjiData(GetDataType.Unstudied);
            }
            else
            {
                kanjis = database.GetKanjiData(GetDataType.Studied);
            }
            this.FillKanjisIntoListView(kanjis);
        }

        private void FillKanjiIntoTextBox(Kanji kanji)
        {
            if (kanji != null)
            {
                this.tbxKanji.Text = kanji.StrKanji;
                this.tbxAmOn.Text = kanji.StrAmon;
                this.tbxAmKun.Text = kanji.StrAmkun;
                this.tbxKanjiMeaning.Text = kanji.StrMeaning;
            }
            else
            {
                this.tbxKanji.Text = string.Empty;
                this.tbxAmOn.Text = string.Empty;
                this.tbxAmKun.Text = string.Empty;
                this.tbxKanjiMeaning.Text = string.Empty;
            }
        }

        private void ClearTextbox()
        {
            this.SelectKanji = null;
            this.tbxKanji.Text = string.Empty;
            this.tbxAmOn.Text = string.Empty;
            this.tbxAmKun.Text = string.Empty;
            this.tbxKanjiMeaning.Text = string.Empty;
        }

        private bool IsDataChanged()
        {
            if (this.SelectKanji == null)
                return false;

            if (this.SelectKanji.StrKanji != this.tbxKanji.Text ||
                this.SelectKanji.StrAmon != this.tbxAmOn.Text ||
                this.SelectKanji.StrAmkun != this.tbxAmKun.Text ||
                this.SelectKanji.StrMeaning != tbxKanjiMeaning.Text)
                return true;

            return false;
        }

        private void FillKanjisIntoListView(List<Kanji> kanjis)
        {
            foreach (Kanji kanji in kanjis)
            {
                if (null != kanji)
                {
                    ListViewItem lvi = new ListViewItem(new string[] {"",kanji.StrKanji, kanji.StrAmon, kanji.StrAmkun,kanji.StrMeaning});
                    lvi.Checked = kanji.IsStudied;
                    this.livKanji.Items.Add(lvi);
                }
            }
            for (int index = 0; index < kanjis.Count; index++)
            {
                if (null != kanjis[index])
                {
                    livKanji.Items[index].Tag = kanjis[index];
                }
            }
        }

        private void btnKanjiDelete_Click(object sender, EventArgs e)
        {
            if (this.SelectKanji != null)
            {
                Database db = new Database();
                if (db.DeleteKanji(SelectKanji) > 0)
                {


                    ListViewItem lvi = GetListViewItemByKanji(SelectKanji);
                    livKanji.Items.Remove(lvi);
                    this.SelectKanji = null;

                }
            }
        }

        private void rdoKanjiUnStudied_CheckedChanged(object sender, EventArgs e)
        {
            if(rdoKanjiUnStudied.Checked)
                RefreshData();
        }

        private void rdoKanjiStudied_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKanjiStudied.Checked)
                RefreshData();
        }

        private void rdoKanjiAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKanjiAll.Checked)
                RefreshData();
        }

        private void tbxKanji_TextChanged(object sender, EventArgs e)
        {
            this.btnKanjiUpdate.Enabled = this.IsDataChanged();
            this.btnKanjiAdd.Enabled = this.HasData();
        }

        //private void txtKana_TextChanged(object sender, EventArgs e)
        //{
        //    this.btnKanjiUpdate.Enabled = this.IsDataChanged();
        //    this.btnKanjiAdd.Enabled = this.HasData();
        //}

        //private void txtVietnamese_TextChanged(object sender, EventArgs e)
        //{
        //    this.btnKanjiUpdate.Enabled = this.IsDataChanged();
        //    this.btnKanjiAdd.Enabled = this.HasData();
        //}

        private void tbxKanjiMeaning_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift)
            {
                picKanjiTyping_Click(picKanjiTyping, new EventArgs());
            }
        }

        private void btnKanjiUpdate_Click(object sender, EventArgs e)
        {
            if (!IsValidDataInput()) return;
            Database db = new Database();
            Kanji temp = new Kanji();
            temp.Id = SelectKanji.Id;
            temp.StrKanji = this.tbxKanji.Text;
            temp.StrAmon = this.tbxAmOn.Text;
            temp.StrAmkun = this.tbxAmKun.Text;
            temp.StrMeaning = this.tbxKanjiMeaning.Text;
            temp.StrSample = string.Empty;

            if (db.UpdateKanji(temp) > 0)
            {
                ListViewItem lvi = this.GetListViewItemByKanji(this.SelectKanji);
                this.SelectKanji = temp;
                lvi.Tag = temp;
                lvi.SubItems[0].Text = "";
                lvi.SubItems[1].Text = SelectKanji.StrKanji;
                lvi.SubItems[2].Text = SelectKanji.StrAmon;
                lvi.SubItems[3].Text = SelectKanji.StrAmkun;
                lvi.SubItems[4].Text = SelectKanji.StrMeaning;
                btnKanjiUpdate.Enabled = false;
            }
        }

        bool IsValidDataInput()
        {
            //if (string.IsNullOrEmpty(tbxKanji.Text.Trim()))
            //{
            //    MessageBox.Show("Bạn cần chưa nhập vào từ Kanji? Xin vui lòng  nhập vào trước khi cập nhật.");
            //    tbxKanji.Focus();
            //    return false;
            //}
            //if (string.IsNullOrEmpty(tbxKanjiMeaning.Text.Trim()))
            //{
            //    MessageBox.Show("Bạn cần chưa nhập vào tiếng Việt của từ này? Xin vui lòng  nhập vào trước khi cập nhật.");
            //    tbxKanjiMeaning.Focus();
            //    return false;
            //}
            return true;
        }

        private ListViewItem GetListViewItemByKanji(Kanji kanji)
        {
            foreach (ListViewItem lvi in livKanji.Items)
            {
                if (lvi.Tag == this.SelectKanji)
                {
                    return lvi;
                }
            }
            return null;
        }

        private void btnClearText_Click(object sender, EventArgs e)
        {
            this.SelectKanji = null;
        }

        private void btnKanjiAdd_Click(object sender, EventArgs e)
        {
            if (!IsValidDataInput()) return;

            Kanji kanji = new Kanji();
            kanji.StrKanji = this.tbxKanji.Text;
            kanji.StrAmon = this.tbxAmOn.Text;
            kanji.StrAmkun = this.tbxAmKun.Text;
            kanji.StrMeaning = this.tbxKanjiMeaning.Text;
            kanji.StrSample = string.Empty;

            Database db = new Database();
            int i = db.InsertKanji(kanji);

            if (i > 0)
            {
                ListViewItem lvi = this.livKanji.Items.Add(new ListViewItem(new string[] { "", kanji.StrKanji, kanji.StrAmon, kanji.StrAmkun, kanji.StrMeaning }));
                lvi.Tag = kanji;
                this.SelectKanji = null;
                this.tbxKanji.Focus();
            }
            else
            {
                MessageBox.Show("Thêm từ không thành công. Hãy thử lại!", "JWord", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private bool HasData()
        {
            return  (this.tbxKanji.Text.Trim() != "") ||
                    (this.tbxAmOn.Text.Trim() != "") ||
                    (this.tbxAmKun.Text.Trim() != "") ||
                    (this.tbxKanjiMeaning.Text.Trim() != "");
        }

        private void livKanji_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            Database db = new Database();
            if (e.Item.Tag != null)
            {
                Kanji kanji = e.Item.Tag as Kanji;
                if (kanji.IsStudied != e.Item.Checked)
                {
                    kanji.IsStudied = e.Item.Checked;
                    db.UpdateKanji(kanji);
                }
            }
        }

        private void btnKanjiSetUnStudied_Click(object sender, EventArgs e)
        {
            if (livKanji.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn ít nhất một từ.","JWord", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SetUnStudied();
            //System.Threading.Thread setThread = new System.Threading.Thread(SetUnStudied);
            //setThread.Priority = System.Threading.ThreadPriority.Highest;
            //setThread.Start();
        }

        private void btnKanjiSetStudied_Click(object sender, EventArgs e)
        {
            if (livKanji.SelectedItems.Count == 0)
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
            foreach (ListViewItem lvi in livKanji.SelectedItems)
            {
                if (lvi.Tag != null && lvi.Tag is Kanji)
                {
                    Kanji kanji = lvi.Tag as Kanji;
                    kanji.IsStudied = true;
                    if (db.UpdateKanji(kanji) >= 1)
                    {
                        lvi.Checked = true;
                    }
                }
            }
        }

        private void SetUnStudied()
        {
            Database db = new Database();
            foreach (ListViewItem lvi in livKanji.SelectedItems)
            {
                if (lvi.Tag != null && lvi.Tag is Kanji)
                {
                    Kanji kanji = lvi.Tag as Kanji;
                    kanji.IsStudied = true;
                    if (db.UpdateKanji(kanji) >= 1)
                    {
                        lvi.Checked = false;
                    }
                }
            }
        }

        private void btnKanjiDeleleAll_Click(object sender, EventArgs e)
        {
            if (livKanji.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn ít nhất một từ.", "JWord", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Database db = new Database();

            foreach (ListViewItem lvi in livKanji.SelectedItems)
            {
                if (lvi.Tag != null && lvi.Tag is Kanji)
                {
                    Kanji kanji = lvi.Tag as Kanji;
                    if (db.DeleteKanji(kanji) >= 1)
                    {
                        livKanji.Items.Remove(lvi);
                    }
                }
            }
        }

        private void picKanjiTyping_Click(object sender, EventArgs e)
        {
            isVietNamese = !isVietNamese;
            if (isVietNamese)
            {
                tbxKanjiMeaning.KeyPress += keyPressHandler;
                picKanjiTyping.Image = global::JWord.Properties.Resources.vi;
            }
            else
            {
                tbxKanjiMeaning.KeyPress -= keyPressHandler;
                picKanjiTyping.Image = global::JWord.Properties.Resources.en;
            }
        }

        private bool isVietNamese = true;
        private VietKeyHandler keyHandler;

        private KeyPressEventHandler keyPressHandler;

        //private void livKanji_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.Control && e.KeyValue == 65)
        //    {
        //        foreach(ListViewItem liv in livKanji.Items)
        //            liv.Selected = true;
        //    }
        //}

        
    }
}
