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

            button1.PerformClick();
        }
        Random rd = new Random();
        Word current = new Word();
        private void button1_Click(object sender, EventArgs e)
        {
            this.lblKanji.Text = "";
            this.lblKunyomi.Text = "";
            this.lblOnyomi.Text = "";

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
