using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

namespace JWord
{
    class DictFileManager
    {
        private const string DICT_PATH = "Dict";
        private const string INDEX_EXT = ".idx";
        private const string DATA_EXT = ".dat";
        private List<DictFileInfo> allDict;

        public delegate void GetMeaningCompleteDelegate(GetMeaningCompleteArgs args);
        public static event GetMeaningCompleteDelegate OnGetMeaningComplete;
        
        private static ParameterizedThreadStart threadStart = new ParameterizedThreadStart(DictFileManager.GetMeaning);
        Thread thread = null;

        public void Init()
        {
            List<DictFileInfo> dictList = new List<DictFileInfo>();
            DirectoryInfo dirInfo;
            try
            {
                dirInfo = new DirectoryInfo(DICT_PATH);
            }
            catch
            {
                return;
            }

            foreach (DirectoryInfo subDirInfo in dirInfo.GetDirectories())
            {
                FileInfo dataFileInfo;
                FileInfo idxFileInfo;
                try
                {
                    dataFileInfo = new FileInfo(subDirInfo.FullName + "\\" + subDirInfo.Name + DATA_EXT);
                    idxFileInfo = new FileInfo(subDirInfo.FullName + "\\" + subDirInfo.Name + INDEX_EXT);
                }
                catch
                {
                    continue;
                }

                if (dataFileInfo.Exists && idxFileInfo.Exists)
                {
                    IndexFileInfo indexFileInfo = new IndexFileInfo();
                    indexFileInfo.Path = idxFileInfo.FullName;
                    indexFileInfo.Init();

                    DictFileInfo dictFileInfo = new DictFileInfo();
                    dictFileInfo.Path = dataFileInfo.FullName;
                    dictFileInfo.IndexFile = indexFileInfo;

                    dictList.Add(dictFileInfo);
                }
            }

            allDict = dictList;
        }

        public void StartGetMeaning(string word)
        {
            GetMeaningArgs arg = new GetMeaningArgs(word, allDict);
            thread = new Thread(threadStart);
            thread.Start(arg);
        }

        public void StopGetMeaing()
        {
            try
            {
                if (thread.IsAlive)
                {
                    thread.Abort();
                    thread.Join();
                    thread = null;
                }
            }
            catch
            {
            }
        }

        private static void GetMeaning(object arg)
        {
            if (arg is GetMeaningArgs)
            {
                GetMeaningArgs arg2 = arg as GetMeaningArgs;
                if ((arg2.Word == null) || (arg2.AllDicts == null))
                {
                    GetMeaningCompleteArgs arg3 = new GetMeaningCompleteArgs();
                    arg3.Meaning = "";
                    arg3.GetMeaningArgs = arg2;
                    OnGetMeaningComplete(arg3);
                    return;
                }

                foreach (DictFileInfo dict in arg2.AllDicts)
                {
                    IndexEntry index;
                    if ((index = dict.IndexFile[arg2.Word]) != null)
                    {
                        int offset = GetDecValue(index.Offset);
                        int length = GetDecValue(index.Length);

                        string mean = GetWordMeaning(offset, length, dict.Path);

                        if (OnGetMeaningComplete != null)
                        {
                            GetMeaningCompleteArgs arg3 = new GetMeaningCompleteArgs();
                            arg3.Meaning = mean;
                            arg3.GetMeaningArgs = arg2;
                            OnGetMeaningComplete(arg3);
                        }
                    }
                    else
                    {
                        GetMeaningCompleteArgs arg3 = new GetMeaningCompleteArgs();
                        arg3.Meaning = "";
                        arg3.GetMeaningArgs = arg2;
                        OnGetMeaningComplete(arg3);
                    }
                }
            }
        }

        static private string GetWordMeaning(int offset, int len, string path)
        {
            try
            {
                // Ðọc từ điển để lấy nghĩa của từ
                using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None))
                {
                    // Byte để giữ nghĩa của từ
                    byte[] b = new byte[len];

                    // Setup cái offset
                    fs.Position = offset;

                    // Ðọc [FileStream.Read(byte[] buffer, int offset, in length)
                    // 0 tại mình đã setup cái offset ở line trên rồi
                    fs.Read(b, 0, b.Length);

                    // Chuyển byte[] qua unicode( utf-8 ) string, rồi return
                    return System.Text.Encoding.UTF8.GetString(b);
                }
            }
            catch
            {
                return null;
            }
        }

        // 64bit string value
        static string g64Value = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";

        // CSharp decimal converter  [function still needs validation]
        static private int GetDecValue(string num)
        {
            char[] chars = num.ToCharArray();
            int decValue = 0, charValue = 0;
            int len = chars.Length;

            for (int i = 0; i < len; i++)
            {
                // Get based 64 value
                charValue = g64Value.IndexOf(chars[i]);

                // Calculate power value
                decValue += (int)Math.Pow(64, len - i - 1) * charValue;
            }

            return decValue;
        }
    }

    class GetMeaningCompleteArgs
    {
        private GetMeaningArgs getMeaningArgs;

        internal GetMeaningArgs GetMeaningArgs
        {
            get { return getMeaningArgs; }
            set { getMeaningArgs = value; }
        }

        private string meaning;

        public string Meaning
        {
            get { return meaning; }
            set { meaning = value; }
        }
    }

    class IndexEntry
    {
        public IndexEntry(string offSet, string length, string word)
        {
            this.offSet = offSet;
            this.length = length;
            this.word = word;
        }

        string offSet;

        public string Offset
        {
            get { return offSet; }
            set { offSet = value; }
        }

        string length;

        public string Length
        {
            get { return length; }
            set { length = value; }
        }

        string word;

        public string Word
        {
            get { return word; }
            set { word = value; }
        }
    }

    class IndexFileInfo
    {
        string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        Dictionary<string, IndexEntry> indexList = new Dictionary<string, IndexEntry>();

        public IndexEntry this[string word]
        {
            set
            {
                if (!indexList.ContainsKey(word))
                {
                    indexList.Add(word, value);
                }
                else
                {
                    indexList[word] = value;
                }
            }

            get
            {
                if (indexList.ContainsKey(word))
                {
                    return indexList[word];
                }
                return null;
            }
        }

        public void Init()
        {
            StreamReader sr = new StreamReader(path);
           
            while (sr.Peek() > 0)
            {
                string temp = sr.ReadLine();
                
                if (temp == null || temp == "")
                {
                    continue;
                }

                string[] strs = temp.Split(new char[]{'\t'});

                if (strs.Length == 3)
                {
                    IndexEntry idxEntry = new IndexEntry(strs[1], strs[2], strs[0]);
                    if (!indexList.ContainsKey(strs[0]))
                    {
                        indexList.Add(strs[0], idxEntry);
                    }
                }
            }
        }
    }

    class DictFileInfo
    {
        string path;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }

        private IndexFileInfo indexFile;

        internal IndexFileInfo IndexFile
        {
            get { return indexFile; }
            set { indexFile = value; }
        }
    }

    class GetMeaningArgs
    {
        string word;

        public string Word
        {
            get { return word; }
            set { word = value; }
        }

        List<DictFileInfo> allDicts;

        internal List<DictFileInfo> AllDicts
        {
            get { return allDicts; }
            set { allDicts = value; }
        }

        public GetMeaningArgs(string word, List<DictFileInfo> dicts)
        {
            this.word = word;
            this.allDicts = dicts;
        }

    }
}
