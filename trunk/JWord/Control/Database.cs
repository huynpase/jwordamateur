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

        #region Get data methods

        public List<Word> GetWordData(GetDataType type)
        {
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
                    w.Kanji = dr["Kanji"] as string;
                    w.Kana = dr["Kana"] as string;
                    w.Meaning = dr["Meaning"] as string;
                    w.IsStudied = (bool)dr["Hide"];
                }
                catch
                {
                    continue;
                }

                if (null!=w.Kana || string.Empty != w.Kana||
                    null != w.Meaning || string.Empty != w.Meaning)
                {
                    w.Kana = null == w.Kana ? string.Empty : w.Kana;
                    w.Kanji = null == w.Kanji ? string.Empty : w.Kanji;
                    w.Meaning = null == w.Meaning ? string.Empty : w.Meaning;
                    w.Romanji = null == w.Romanji ? string.Empty : w.Romanji;
                    arr.Add(w);
                }
            }
            cn.Close();
            return arr;
        }

        public List<Kanji> GetKanjiData(GetDataType type)
        {
            List<Kanji> arr = new List<Kanji>();
            OleDbConnection cn = new OleDbConnection(ConnectionString);
            cn.Open();

            OleDbCommand cmd;
            if (type == GetDataType.All)
            {
                cmd = new OleDbCommand("SELECT * FROM KANJI ", cn);
            }
            else if (type == GetDataType.Studied)
            {
                cmd = new OleDbCommand("SELECT * FROM KANJI WHERE Hide = true", cn);
            }
            else
            {
                cmd = new OleDbCommand("SELECT * FROM KANJI WHERE Hide = false", cn);
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
                Kanji k = new Kanji();

                try
                {
                    k.Id = (int)dr["Id"];
                    k.StrKanji = dr["Kanji"] as string;
                    k.StrAmon = dr["Amon"] as string;
                    k.StrAmkun = dr["Amkun"] as string;
                    k.StrMeaning = dr["Meaning"] as string;
                    k.StrSample = dr["Sample"] as string;
                    k.IsStudied = (bool)dr["Hide"];
                }
                catch
                {
                    continue;
                }

                if (null != k.StrKanji && !string.IsNullOrEmpty(k.StrKanji.Trim()) &&
                    null != k.StrMeaning && !string.IsNullOrEmpty(k.StrMeaning.Trim()) )
                {
                    k.StrAmon = null == k.StrAmon ? string.Empty : k.StrAmon;
                    k.StrAmkun = null == k.StrAmkun ? string.Empty : k.StrAmkun;
                    k.StrSample = null == k.StrSample ? string.Empty : k.StrSample;
                    arr.Add(k);
                }
            }
            cn.Close();
            return arr;
        }

        #endregion

        #region Delete methods

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

        public int DeleteKanji(Kanji kanji)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(ConnectionString);
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("DeleteKanji", cn);
                cmd.Parameters.Add(new OleDbParameter("@Id", kanji.Id));
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

        #endregion

        #region Upadate methods

        public int UpdateWord(Word word)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(ConnectionString);
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("UpdateWord", cn);
                cmd.Parameters.Add(new OleDbParameter("@Kanji", null != word.Kanji?word.Kanji:string.Empty));
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

        public int UpdateKanji(Kanji kanji)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(ConnectionString);
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("UpdateKanji", cn);
                cmd.Parameters.Add(new OleDbParameter("@Id", kanji.Id));
                cmd.Parameters.Add(new OleDbParameter("@Kanji", kanji.StrKanji));
                cmd.Parameters.Add(new OleDbParameter("@Amon", null != kanji.StrAmon ? kanji.StrAmon : string.Empty));
                cmd.Parameters.Add(new OleDbParameter("@Amkun", null != kanji.StrAmkun ? kanji.StrAmkun : string.Empty));
                cmd.Parameters.Add(new OleDbParameter("@Meaning",kanji.StrMeaning));
                cmd.Parameters.Add(new OleDbParameter("@Sample", null != kanji.StrSample ? kanji.StrSample : string.Empty));
                cmd.Parameters.Add(new OleDbParameter("@Hide", kanji.IsStudied));
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

        #endregion

        #region Insert methods

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

        public int InsertKanji(Kanji kanji)
        {
            try
            {
                OleDbConnection cn = new OleDbConnection(ConnectionString);
                cn.Open();
                OleDbCommand cmd = new OleDbCommand("InsertKanji", cn);
                cmd.Parameters.Add(new OleDbParameter("@Kanji", kanji.StrKanji));
                cmd.Parameters.Add(new OleDbParameter("@Amon", kanji.StrAmon));
                cmd.Parameters.Add(new OleDbParameter("@Amkun", kanji.StrAmkun));
                cmd.Parameters.Add(new OleDbParameter("@Meaning", kanji.StrMeaning));
                cmd.Parameters.Add(new OleDbParameter("@Sample", kanji.StrSample));
                cmd.Parameters.Add(new OleDbParameter("@Hide", kanji.IsStudied));
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
        
        #endregion

        #region Get last methods

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

        #endregion
    }

    public enum GetDataType{
        All,
        Studied,
        Unstudied
    }
    
    /// <summary>
    /// Class Word which is wapper of word table in database
    /// </summary>
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

    /// <summary>
    /// Class Kanji which is wapper of kanji table in database
    /// </summary>
    class Kanji
    {
        private int id;
        private string strKanji;
        private string strAmon;
        private string strAmkun;
        private string strMeaning;
        private string strSample;
        private bool isStudied;

        public bool IsStudied
        {
            get { return isStudied; }
            set { isStudied = value; }
        }

        public string StrSample
        {
            get { return strSample; }
            set { strSample = value; }
        }

        public string StrMeaning
        {
            get { return strMeaning; }
            set { strMeaning = value; }
        }

        public string StrAmkun
        {
            get { return strAmkun; }
            set { strAmkun = value; }
        }

        public string StrAmon
        {
            get { return strAmon; }
            set { strAmon = value; }
        }

        public string StrKanji
        {
            get { return strKanji; }
            set { strKanji = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
