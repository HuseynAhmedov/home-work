using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Student
    {
        private byte _age;
        public byte Age 
        {
            get { return _age; }
            set 
            {
                if (value > 0 && value < 100)
                {
                    _age = value;
                }
            } 
        }

        private string _fullname;
        public string FullName 
        {
            get 
            {
                return _fullname;
            }
            private set { _fullname = value; }
        }

        private string _groupNo;
        public string GroupNo 
        {
            get 
            {
                return _groupNo;
            }
            set 
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            } 
        }

        public Student(string name_ , string surname_ , string groupNo_ , byte age_)
        {
            if (CheckStr(name_) && CheckStr(surname_))
            {
                FullName = FixFullName(name_, surname_);
            }
            this.GroupNo = groupNo_;
            this.Age = age_;
        }

        public static bool CheckGroupNo(string chkStr)
        {
            chkStr = chkStr.Trim();
            if (Char.IsLetter(chkStr[0]) && Char.IsUpper(chkStr[0]) && chkStr.Length == 4)
            {
                for (int i = 1; i < 4; i++)
                {
                    if (!Char.IsDigit(chkStr[i])) return false;
                }
            }
            else return false;
            
            return true;
        }

        public static bool CheckStr(string chkStr )
        {
            if (!String.IsNullOrWhiteSpace(chkStr))
            {
                   foreach (var item in chkStr.Trim())
                   {
                        if (!Char.IsLetter(item)) return false;
                   }
            }
            else
            {
                return false;
            }
            return true;
        }

        private string FixFullName (string _name , string surname_)
        {
            
            string fixedFullName = _name.Trim().ToCapitalize();
            fixedFullName += " " + surname_.Trim().ToCapitalize();
            return fixedFullName;
        }
    }
}
