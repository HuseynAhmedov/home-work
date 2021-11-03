using HW_app.Custom_exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class User
    {
        private string _userName;
        public string UserName 
        {
            get 
            {
                return _userName;
            }
            set 
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    if (6 < value.Length && value.Length < 25) _userName = value;
                    else throw new InvalidUserNameException();
                }
                else throw new InvalidUserNameException();
            } 
        }

        private string _password;

        public string PassWord 
        {
            get 
            {
                return _password;
            }
            set 
            {
                if (!String.IsNullOrWhiteSpace(value))
                {
                    if (8 < value.Length && value.Length < 25)
                    {
                        bool checkDigit = false;
                        bool checkLower = false;
                        bool cheakUpper = false;
                        bool checkMain = false;

                        for (int i = 0; i < value.Length; i++)
                        {

                            if (checkDigit == false && Char.IsDigit(value[i])) checkDigit = true;

                            if (checkLower == false && Char.IsLower(value[i])) checkLower = true;

                            if (cheakUpper == false && Char.IsUpper(value[i])) cheakUpper = true;

                            if (cheakUpper == true && checkDigit == true && checkLower == true)
                            {
                                checkMain = true;
                                break;
                            }
                        }

                        if (checkMain) _password = value;
                        else throw new PasswordIncorrectException();
          
                    }
                    else throw new PasswordIncorrectException();
                }
                else throw new PasswordIncorrectException();
            } 
        }

        public User (string nameInput)
        {
            this.UserName = nameInput;
        }
    }
}
