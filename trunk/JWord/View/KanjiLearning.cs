using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JWord
{
    public partial class KanjiLearning : Form
    {
        static bool isStarted = false;
        public KanjiLearning()
        {
            InitializeComponent();
            RefeshData();
            NextKanji();
        }

        public void NextKanji()
        {
            int numberOfKanji = kanjisList.Count;
            
            isClickLbKanji = false;
            isClickLbKunyomi = false;
            isClickLbMeaning = false;
            isClickLbOnyomi = false;
            
            if (numberOfKanji == 0)
            {
                setKanjiForShow(null);
                panelLockView.Visible = true;
                indexOfCurrentKanji = -1;
                currentKanji = null;
                return;
            }
            indexOfCurrentKanji = (++indexOfCurrentKanji) % kanjisList.Count;
            currentKanji = kanjisList[indexOfCurrentKanji];
            setKanjiForShow(currentKanji);
            SetShowByConfiguration();
        }

        public void PreKanji()
        {
            int numberOfKanji = kanjisList.Count;

            isClickLbKanji = false;
            isClickLbKunyomi = false;
            isClickLbMeaning = false;
            isClickLbOnyomi = false;
            
            if (numberOfKanji == 0)
            {
                setKanjiForShow(null);
                panelLockView.Visible = true;
                indexOfCurrentKanji = -1;
                currentKanji = null;
                return;
            }
            indexOfCurrentKanji = indexOfCurrentKanji == 0 ? kanjisList.Count-1 : (--indexOfCurrentKanji);
            currentKanji = kanjisList[indexOfCurrentKanji];
            setKanjiForShow(currentKanji);
            SetShowByConfiguration();
        }

        public void RefeshData()
        {
            kanjisList = dbManage.GetKanjiData(GetDataType.Unstudied);
            currentKanji = null;
            indexOfCurrentKanji = -1;
        }

        private void setKanjiForShow(Kanji kanji)
        {
            if (null == kanji)
            {
                lbKanji.Text = string.Empty;
                lbMeaning.Text = string.Empty;
                lbOnyomi.Text = string.Empty;
                lbKunyomi.Text = string.Empty;
                picShowKanjiImg.Image = null;
                return;
            }
            lbKanji.Text = kanji.StrKanji;
            lbMeaning.Text = kanji.StrMeaning;
            lbOnyomi.Text = kanji.StrAmon;
            lbKunyomi.Text = kanji.StrAmkun;
            SetImageForKanji(kanji);
        }

        private void SetShowByConfiguration()
        {
            panelLockView.Visible = !Configuration.ShowKanji;
            lbKanji.ForeColor = Configuration.ShowKanji ? System.Drawing.Color.Red : System.Drawing.Color.PeachPuff;
            lbMeaning.ForeColor = Configuration.ShowMeaning ? System.Drawing.Color.DarkRed : System.Drawing.Color.LightGreen;
            lbOnyomi.ForeColor = Configuration.ShowOnyomi ? System.Drawing.Color.Black : System.Drawing.Color.Thistle;
            lbKunyomi.ForeColor = Configuration.ShowKunyomi ? System.Drawing.Color.DarkOliveGreen : System.Drawing.Color.PaleGoldenrod;
        }


        private void SetImageForKanji(Kanji kanji)
        {
            if (null == kanji)
            {
                picShowKanjiImg.Image = null;
                return;
            }
            int codeInt = Convert.ToInt32(kanji.StrKanji[0]);
            string codeHexa = ToHex(codeInt);
            picShowKanjiImg.ImageLocation = string.Format(@"Kanji\{0}.gif", codeHexa);
        }

        private void panelLockView_Click(object sender, EventArgs e)
        {
            if (isClickLbKanji || Configuration.ShowKanji) return;
            panelLockView.Visible = false;
            lbKanji_Click(lbKanji, e);
        }

        
        #region PicNext fuctions

        private void picNext_MouseHover(object sender, EventArgs e)
        {
            picNext.BackgroundImage = global::JWord.Properties.Resources.next_on;
        }

        private void picNext_MouseLeave(object sender, EventArgs e)
        {
            picNext.BackgroundImage = global::JWord.Properties.Resources.next_off;
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            NextKanji();
        }

        #endregion

        #region PicBack fuctions

        private void picBack_MouseHover(object sender, EventArgs e)
        {
            picBack.BackgroundImage = global::JWord.Properties.Resources.back_on;
        }

        private void picBack_MouseLeave(object sender, EventArgs e)
        {
            picBack.BackgroundImage = global::JWord.Properties.Resources.back_off;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            PreKanji();
        }

        #endregion

        #region LbKanji fuctions

        private void lbKanji_MouseHover(object sender, EventArgs e)
        {
            if (isClickLbKanji || Configuration.ShowKanji) return;
            lbKanji.ForeColor = System.Drawing.Color.Red;
        }

        private void lbKanji_MouseLeave(object sender, EventArgs e)
        {
            if (isClickLbKanji || Configuration.ShowKanji) return;
            lbKanji.ForeColor = System.Drawing.Color.PeachPuff;
        }

        private void lbKanji_Click(object sender, EventArgs e)
        {
            if (isClickLbKanji || Configuration.ShowKanji) return;
            lbKanji.ForeColor = System.Drawing.Color.Red;
            panelLockView.Visible = false;
            isClickLbKanji = true;
        }

        #endregion

        #region LbMeaning fuctions
        
        private void lbMeaning_MouseHover(object sender, EventArgs e)
        {
            if (isClickLbMeaning || Configuration.ShowMeaning) return;
            lbMeaning.ForeColor = System.Drawing.Color.DarkRed;
        }

        private void lbMeaning_MouseLeave(object sender, EventArgs e)
        {
            if (isClickLbMeaning || Configuration.ShowMeaning) return;
            lbMeaning.ForeColor = System.Drawing.Color.LightGreen;
        }

        private void lbMeaning_Click(object sender, EventArgs e)
        {
            if (isClickLbMeaning || Configuration.ShowMeaning) return;
            lbMeaning.ForeColor = System.Drawing.Color.DarkRed;
            isClickLbMeaning = true;
        }

        #endregion

        #region LbOnyomi fuctions

        private void lbOnyomi_MouseHover(object sender, EventArgs e)
        {
            if (isClickLbOnyomi || Configuration.ShowOnyomi) return;
            lbOnyomi.ForeColor = System.Drawing.Color.Black;
        }

        private void lbOnyomi_MouseLeave(object sender, EventArgs e)
        {
            if (isClickLbOnyomi || Configuration.ShowOnyomi) return;
            lbOnyomi.ForeColor = System.Drawing.Color.Thistle;
        }

        private void lbOnyomi_Click(object sender, EventArgs e)
        {
            if (isClickLbOnyomi || Configuration.ShowOnyomi) return;
            lbOnyomi.ForeColor = System.Drawing.Color.Black;
            isClickLbOnyomi = true;
        }

        #endregion

        #region LbKunyomi fuctions

        private void lbKunyomi_MouseHover(object sender, EventArgs e)
        {
            if (isClickLbKunyomi || Configuration.ShowKunyomi) return;
            lbKunyomi.ForeColor = System.Drawing.Color.DarkOliveGreen;
        }

        private void lbKunyomi_MouseLeave(object sender, EventArgs e)
        {
            if (isClickLbKunyomi || Configuration.ShowKunyomi) return;
            lbKunyomi.ForeColor = System.Drawing.Color.PaleGoldenrod;
        }

        private void lbKunyomi_Click(object sender, EventArgs e)
        {
            if (isClickLbKunyomi || Configuration.ShowKunyomi) return;
            lbKunyomi.ForeColor = System.Drawing.Color.DarkOliveGreen;
            isClickLbKunyomi = true;
        }

        #endregion


        private string ToHex(int number)
        {
            int r = number % 16;
            if (number - r == 0) { return ToChar(r); }
            else { return ToHex((number - r) / 16) + ToChar(r); }
        }

        private string ToChar(int r)
        {
            string alpha = "0123456789ABCDEF";
            return alpha[r].ToString();
        }


        private bool isClickLbKanji = false;
        private bool isClickLbMeaning = false;
        private bool isClickLbOnyomi = false;
        private bool isClickLbKunyomi = false;

        private int indexOfCurrentKanji = -1;
        private Kanji currentKanji;
        private List<Kanji> kanjisList;
        Database dbManage = new Database();

        private void KanjiLearning_KeyUp(object sender, KeyEventArgs e)
        {
            if (13 == e.KeyValue || 38 == e.KeyValue || 37 == e.KeyValue)
            {
                this.NextKanji();
            }

            else if (39 == e.KeyValue || 40 == e.KeyValue)
            {
                this.NextKanji();
            }
        }

       
    }
}
