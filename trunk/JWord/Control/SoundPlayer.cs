using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JWord
{
    class SoundPlayer
    {
        private static System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        public static bool Play(string word)
        {
            // find word
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo("Audio");
                foreach(DirectoryInfo subdirInfo in dirInfo.GetDirectories("*", SearchOption.AllDirectories))
                {
                    foreach (FileInfo fileInfo in subdirInfo.GetFiles("*.wav"))
                    {
                        string fileName = fileInfo.Name.ToLower().Replace(".wav", "");
                        if (fileName == word)
                        {
                            soundPlayer.SoundLocation = fileInfo.FullName;
                            soundPlayer.Play();
                            return true;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}
