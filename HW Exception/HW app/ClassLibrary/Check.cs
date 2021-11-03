using System;

namespace ClassLibrary
{
    public class Check
    {
        
        public bool HasDigit(string checkStr)
        {
            if (!String.IsNullOrWhiteSpace(checkStr))
            {
                char[] strCharArr = checkStr.ToCharArray();
                foreach (var item in checkStr)
                {
                    if (Char.IsDigit(item)) return true;
                }
            }
            return false;
        }
        
        public bool HasUpper (string checkStr)
        {
            if (!String.IsNullOrWhiteSpace(checkStr))
            {
                char[] strCharArr = checkStr.ToCharArray();
                foreach (var item in checkStr)
                {
                    if (Char.IsUpper(item)) return true;
                }
            }
            return false;
        }

        public bool HasLower(string checkStr)
        {
            if (!String.IsNullOrWhiteSpace(checkStr))
            {
                char[] strCharArr = checkStr.ToCharArray();
                foreach (var item in checkStr)
                {
                    if (Char.IsLower(item)) return true;
                }
            }
            return false;
        }

    }
}
