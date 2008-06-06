using System;
using System.Collections.Generic;
using System.Text;

namespace JWord
{
    class Configuration
    {
        //I hate properties
        public static int Space = JWord.Properties.Settings.Default.DockSpace;
        public static int Place = JWord.Properties.Settings.Default.DockPos;
        public static float DefaultOpacity = JWord.Properties.Settings.Default.Opacity;
        public static int FreezeTime = JWord.Properties.Settings.Default.FreezeTime;
        public static bool ShowKanji = JWord.Properties.Settings.Default.ShowKanji;
        public static int Position = JWord.Properties.Settings.Default.Pos;
    }
}
