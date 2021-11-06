using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    static class ExtentionMethods
    {
        public static bool IsOdd (this int chkNum)
        {
            if (chkNum % 2 != 0) return true;
            
            return false;
        }

        public static bool IsEven(this int chkNum)
        {
            if (chkNum % 2 == 0) return true;
            
            return false;
        }

        public static bool IsContainsDigit(this string chkStr)
        {
            char[] charChk = chkStr.ToCharArray();
            foreach (var item in charChk)
            {
                if (Char.IsDigit(item)) return true;
            }
            return false;
        }

        public static string ToCapitalize(this string strCapitilize)
        {
            StringBuilder sb = new StringBuilder();
            string fixedStr = "";
            for (int i = 0; i < strCapitilize.Length; i++)
            {
                if (Char.IsLetter(strCapitilize[i]))
                {
                    sb.Insert(i ,strCapitilize[i].ToString().ToUpper() + strCapitilize.Substring(i+1));
                    break;
                }
                else
                {
                    sb.Insert(i ,strCapitilize[i]);
                }
            }
            fixedStr = sb.ToString();
            return fixedStr;
        }

        public static int [] GetValueIndexes(this string chkStr , char watedStr)
        {
            char [] charStrArr = chkStr.ToCharArray();
            int[] charIndex = new int[0];
            int i = 0;
            foreach (var item in charStrArr)
            {
                if (item == watedStr)
                {
                    Array.Resize(ref charIndex,charIndex.Length+1);
                    charIndex[charIndex.Length - 1] = i;
                }
                i++;
            }
            return charIndex;
        }
    }
}
