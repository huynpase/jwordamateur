using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.OleDb;
using JWord.Properties;

namespace JWord
{
    class Database
    {
        private string ConnectionString = JWord.Properties.Settings.Default.dbConnectionString;
        
        public List<Word> GetData(GetDataType type)
        {
            JWord.Properties.Settings st = new Settings();
            List<Word> arr = new List<Word>();
            OleDbConnection cn = new OleDbConnection(ConnectionString);
            cn.Open();
            
            OleDbCommand cmd;
            if (type == GetDataType.All)
            {
                cmd = new OleDbCommand("SELECT * FROM WORDS ",cn);
            }
            else if (type == GetDataType.Studied)
            {
                cmd = new OleDbCommand("SELECT * FROM WORDS WHERE Hide = true", cn);
            }
            else
            {
                cmd = new OleDbCommand("SELECT * FROM WORDS WHERE Hide = false", cn);
            }

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            int i = da.Fill(dt);
            if (i == 0)
            {
                cn.Close();
                return arr;
            }

            foreach (DataRow dr in dt.Rows)
            {
                Word w = new Word();

                try
                {
                    w.Id = (int)dr["Id"];
                    w.Kanji = (string)dr["Kanji"];
                    w.Kana = (string)dr["Kana"];
                    w.Meaning = (string)dr["Meaning"];
                    w.IsStudied = (bool)dr["Hide"];
                }
                catch
                {
                    continue;
                }

                if (w.Kana != string.Empty ||
                    w.Kanji != string.Empty ||
                    w.Meaning != string.Empty)
                {
                    arr.Add(w);
                }
            }
            cn.Close();
            return arr;
        }

        public int DeleteWord(Word word)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(ConnectionString);
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("DeleteWord", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
        }
    }

    enum GetDataType{
        All,
        Studied,
        Unstudied
    }
    
    class Word
    {
        #region Private
        private int id;
        private bool studied;

        public bool IsStudied
        {
            get { return studied; }
            set { studied = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string sKanji = "";
        private string sKana = "";
        private string sRomanji = "";
        private string sMeaning = "";
        private string sImagePath = "";
        #endregion
        
        #region Properties
        public string Kanji
        {
            set
            {
                sKanji = value;
            }
            get
            {
                return sKanji;
            }
        }

        public string Kana
        {
            set
            {
                sKana = value;
            }
            get
            {
                return sKana;
            }
        }

        public string Romanji
        {
            set
            {
                sRomanji = value;
            }
            get
            {
                return sRomanji;
            }
        }

        public string Meaning
        {
            set
            {
                sMeaning = value;
            }
            get
            {
                return sMeaning;
            }
        }
        
        public string ImagePath
        {
            set
            {
                sImagePath = "Images\\" + value.Trim();
            }
            get
            {
                return sImagePath;
            }
        }
        #endregion
    }
}
