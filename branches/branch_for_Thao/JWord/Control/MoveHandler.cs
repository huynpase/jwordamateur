using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JWord
{
    class MoveHandler
    {
        public static bool IsDragged = false;
        private static Point OldPos;
        
        public static void MouseDown(System.Windows.Forms.MouseEventArgs e)
        {
            IsDragged = true;
            OldPos = new Point(e.X, e.Y);
            
        }

        public static void MouseUp()
        {
            IsDragged = false;
        }
        
        public static void MouseMove(MainForm sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (IsDragged)
            {
                int space = Configuration.Space;
                int place = Configuration.Place;
                Rectangle desk = Screen.GetWorkingArea(sender.ClientRectangle);
                Rectangle scr = Screen.GetBounds(Screen.PrimaryScreen.Bounds);
                
                Point p1 = new Point(e.X, e.Y);
                Point p2 = sender.PointToScreen(p1);
                Point p3 = new Point(p2.X - OldPos.X,
                                     p2.Y - OldPos.Y);
                
                
                //Left
                if (Math.Abs(p3.X - desk.X) <= space)
                {
                    p3.X = desk.X + place;
                }
                
                //Right
                if (Math.Abs(-p3.X - sender.Width + desk.X + desk.Width) <= space)
                {
                    p3.X = desk.X + desk.Width - sender.Width - place;
                }
                
                //Top
                if (Math.Abs(p3.Y - desk.Y) <= space)
                {
                    p3.Y = desk.Y + place;
                }

                //Bottom
                if (Math.Abs(-p3.Y - sender.Height + desk.Y + desk.Height) <= space)
                {
                    p3.Y = desk.Y + desk.Height- sender.Height - place;
                }
                sender.Location = p3;                
            }
        }
    }
}
