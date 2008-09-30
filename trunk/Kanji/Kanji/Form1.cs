using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Kanji
{
    public partial class Form1 : Form
    {
        List<Word> list = new List<Word>();
        Kakikata kakikata = new Kakikata();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(new FileStream("data.txt", FileMode.Open, FileAccess.Read));
            string temp = null;
            while ((temp = sr.ReadLine()) != null)
            {
                Word w = new Word(temp);
                list.Add(w);
            }

            kakikata.Location = new Point(this.Location.X + this.Width + 15, this.Location.Y);


            this.lblKanji.Text = "";
            this.lblKunyomi.Text = "";
            this.lblOnyomi.Text = "";
            //this.kakikata.Hide();

            if (list.Count == 0)
                return;

            if (IsAllWordShown())
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    list[i].IsShown = false;
                }
            }

            int index = rd.Next(0, list.Count);
            while (list[index].IsShown)
            {
                index = rd.Next(0, list.Count);
            }
            this.label1.Text = list[index].Name;
            this.current = list[index];
            list[index].IsShown = true;
        }

        Random rd = new Random();
        Word current = new Word();
        private void button1_Click(object sender, EventArgs e)
        {
            this.lblKanji.Text = "";
            this.lblKunyomi.Text = "";
            this.lblOnyomi.Text = "";
            //this.kakikata.Hide();

            if (list.Count == 0)
                return;

            if (IsAllWordShown())
            {
                for (int i = 0; i < list.Count - 1; i++)
                {
                    list[i].IsShown = false;
                }
            }

            int index = rd.Next(0, list.Count);
            while (list[index].IsShown)
            {
                index = rd.Next(0, list.Count);
            }
            this.label1.Text = list[index].Name;
            this.current = list[index];
            list[index].IsShown = true;
            ChangeKakikata();
        }

        private bool IsAllWordShown()
        {
            foreach (Word w in list)
            {
                if (!w.IsShown)
                    return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.lblKanji.Text = current.Kanji;
            this.lblOnyomi.Text = current.Onyomi;
            this.lblKunyomi.Text = current.Kunyomi;
        }

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

        private void button3_Click(object sender, EventArgs e)
        {
            int stt = Convert.ToInt32(current.Kanji[0]);
            string stt2 = ToHex(stt);
            kakikata.Location = new Point(this.Location.X + this.Width + 15, this.Location.Y);
            kakikata.SetImage(string.Format(@"Kanji\{0}.gif", stt2));
            kakikata.Show();
        }

        private void ChangeKakikata()
        {
            int stt = Convert.ToInt32(current.Kanji[0]);
            string stt2 = ToHex(stt);
            kakikata.Location = new Point(this.Location.X + this.Width + 15, this.Location.Y);
            kakikata.SetImage(string.Format(@"Kanji\{0}.gif", stt2));
            //kakikata.Show();
        }
    }

    public class Word
    {
        public string Name;
        public string Kanji;
        public string Kunyomi;
        public string Onyomi;
        public bool IsShown = false;

        public Word(string strWord)
        {
            string[] strs = strWord.Split(new char[] { ',' });
            if (strs.Length == 4)
            {
                Name = strs[0];
                Kanji = strs[1];
                Kunyomi = strs[2];
                Onyomi = strs[3];
                IsShown = false;
            }
        }

        public Word()
        {
        }        
    }
}
