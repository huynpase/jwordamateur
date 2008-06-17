using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace JWord
{
    class RtfUtility
    {
        public string GetRtfFromDictionaryString(string strDictEntry)
        {
            string retRtfString = RTF_START;
            StringReader strReader = new StringReader(strDictEntry);
            string tmpStr;
            while ((tmpStr = strReader.ReadLine()) != null)
            {
                try
                {
                    if (tmpStr == "")
                        continue;
                    string tmpNcrDecimalStr = this.ConvertToNCRDecimal(tmpStr);
                    switch (tmpStr[0])
                    {
                        case '@':
                            retRtfString += AT_START + tmpNcrDecimalStr.Remove(0, 1).Trim() + AT_END;
                            break;
                        case '*':
                            retRtfString += ASTERISK_START + tmpNcrDecimalStr.Remove(0, 1).Trim() + ASTERISK_END;
                            break;
                        case '-':
                            retRtfString += MINUS_START + tmpNcrDecimalStr.Remove(0, 1).Trim().Trim() + MINUS_END;
                            break;
                        case '=':
                            retRtfString += EQUAL_START + tmpNcrDecimalStr.Remove(0, 1).Replace("+", ADD_INLINE_START).Trim() + EQUAL_END;
                            break;
                        case '!':
                            retRtfString += EXCLAMATION_START + tmpNcrDecimalStr.Remove(0, 1).Trim() + EXCLAMATION_END;
                            break;
                    }
                }
                catch
                {
                    continue;
                }
            }

            strReader.Close();
            retRtfString += RTF_END;
            return retRtfString;
        }

        string ConvertToNCRDecimal(string str)
        {
            if (str == null)
                return null;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                int code = (int)str[i];

                if (code <= 127)
                {
                    strBuilder.Append(str[i]);
                }
                else
                {
                    strBuilder.Append(string.Format(@"\u{0}?", code.ToString()));
                }
            }
            return strBuilder.ToString();
        }

        private const string RTF_START = @"{\rtf1\ansi\ansicpg932\deff0\deflang1033\deflangfe1041{\fonttbl{\f0\fswiss\fprq2\fcharset0 Tahoma;}{\f1\fswiss\fcharset0 Arial;}{\f2\froman\fprq2\fcharset2 Symbol;}{\f3\fmodern\fprq1\fcharset0 Courier New;}{\f4\fnil\fprq2\fcharset2 Wingdings;}{\f5\froman\fprq2\fcharset0 Times New Roman;}}{\colortbl ;\red204\green0\blue0;}{\*\generator Msftedit 5.41.21.2508;}\viewkind4\uc1";
        private const string RTF_END = @"}";
        private const string AT_START = @"\pard\i\f0\fs20";
        private const string AT_END = @"\i0\f1\par";
        private const string ASTERISK_START = @"\pard\fi-300\sb100\sa50\li460\tx720\f2\'b7\tab\b\i\f0";
        private const string ASTERISK_END = @"\b0\i0\par";
        private const string MINUS_START = @"\pard\fi-300\li730\sb25\sa25\tx1000\cf1\f3 o\tab\b\f0";
        private const string MINUS_END = @"\cf0\b0\par";
        private const string EQUAL_START = @"\pard\fi-300\li1000\sb20\sa20\tx2000\f4\'a7\tab\b\f0";
        private const string EQUAL_END = @"\par";
        private const string EXCLAMATION_START = @"\pard\fi-300\li730\sb15\sa15\cf1\f3 o\tab\b\i\f0";
        private const string EXCLAMATION_END = @"\par";
        private const string ADD_INLINE_START = @"\b0 :";
    }
}
