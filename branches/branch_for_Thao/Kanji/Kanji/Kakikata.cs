using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kanji
{
    public partial class Kakikata : Form
    {
        public Kakikata()
        {
            InitializeComponent();
        }
        public void SetImage(string path)
        {
            this.pictureBox1.ImageLocation = path;
        }

        private void Kakikata_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }
    }
}
