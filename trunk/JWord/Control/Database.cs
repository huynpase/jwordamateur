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
                cmd.Parameters.Add(new OleDbParameter("@Id", word.Id));
                cmd.CommandType = CommandType.StoredProcedure;
                int ret = cmd.ExecuteNonQuery();
                cn.Close();
                return ret;
            }
            catch
            {
                return 0;
            }
        }

        public int UpdateWord(Word word)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(ConnectionString);
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("UpdateWord", cn);
                cmd.Parameters.Add(new OleDbParameter("@Kanji", word.Kanji));
                cmd.Parameters.Add(new OleDbParameter("@Kana", word.Kana));
                cmd.Parameters.Add(new OleDbParameter("@Meaning", word.Meaning));
                cmd.Parameters.Add(new OleDbParameter("@Hide", word.IsStudied));
                cmd.Parameters.Add(new OleDbParameter("@Id", word.Id));
                cmd.CommandType = CommandType.StoredProcedure;
                int ret = cmd.ExecuteNonQuery();
                cn.Close();
                return ret;
            }
            catch
            {
                return 0;
            }
        }

        public int InsertWord(Word word)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(ConnectionString);
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("InsertWord", cn);
                cmd.Parameters.Add(new OleDbParameter("@Kanji", word.Kanji));
                cmd.Parameters.Add(new OleDbParameter("@Kana", word.Kana));
                cmd.Parameters.Add(new OleDbParameter("@Meaning", word.Meaning));
                cmd.Parameters.Add(new OleDbParameter("@Hide", word.IsStudied));
                cmd.CommandType = CommandType.StoredProcedure;
                int ret = cmd.ExecuteNonQuery();
                cn.Close();
                return ret;
            }
            catch
            {
                return 0;
            }
        }

        public Word GetLastWord()
        {
            OleDbConnection cn = new OleDbConnection(ConnectionString);
            cn.Open();
            OleDbCommand cmd = new OleDbCommand("GetLastWord", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            int i = da.Fill(dt);
            Word w = null;

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                
                try
                {
                    w = new Word();
                    w.Id = (int)dr["Id"];
                    w.Kanji = (string)dr["Kanji"];
                    w.Kana = (string)dr["Kana"];
                    w.Meaning = (string)dr["Meaning"];
                    w.IsStudied = (bool)dr["Hide"];
                }
                catch
                {
                }
            }
            cn.Close();
            return w;
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
