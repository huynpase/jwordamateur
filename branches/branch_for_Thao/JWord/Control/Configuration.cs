using System;
using System.Collections.Generic;
using System.Text;

namespace JWord
{
    class Configuration
    {
        //For Main form
        public static int Space = JWord.Properties.Settings.Default.DockSpace;
        public static int Place = JWord.Properties.Settings.Default.DockPos;
        public static float Opacity = JWord.Properties.Settings.Default.Opacity;
        public static int FreezeTime = JWord.Properties.Settings.Default.FreezeTime;
        public static bool ShowKanji = JWord.Properties.Settings.Default.ShowKanji;
        public static int Position = JWord.Properties.Settings.Default.Pos;
        
        //For Kanji learning 
        public static bool ShowKanjiInLearning = JWord.Properties.Settings.Default.ShowKanjiInLearning;
        public static bool ShowMeaning = JWord.Properties.Settings.Default.ShowMeaning;
        public static bool ShowOnyomi = JWord.Properties.Settings.Default.ShowOnyomi;
        public static bool ShowKunyomi = JWord.Properties.Settings.Default.ShowKunyomi;

        //For save configuration
        public static Properties.Settings Config = Properties.Settings.Default;
    }
    public enum LocationType
    {
        TopLeft =1,
        TopRight =2,
        BottonRight=3,
        BottomLeft =4
    };
}
