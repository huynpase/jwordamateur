using System;
using System.Collections.Generic;
using System.Text;

namespace JWord
{
    class Delay
    {      
        public static void FadeShow(MainForm frm)
        {
            //frm.Show();
            for (float f = 0.0F; f < Configuration.Opacity; f = f + 0.05F)
            {
                frm.Opacity = f;
                System.Threading.Thread.Sleep(30);
            }
            frm.Opacity = Configuration.Opacity;
            frm.PlaySound();
        }
        
        public static void FadeHide(MainForm frm)
        {
            for (float f = Configuration.Opacity; f >= 0F; f = f - 0.05F)
            {
                frm.Opacity = f;
                System.Threading.Thread.Sleep(30);
            }
            frm.NextWord();
            frm.Opacity = 0;
            //frm.Hide();
            System.Threading.Thread.Sleep(1000);            
        }
    }
}
