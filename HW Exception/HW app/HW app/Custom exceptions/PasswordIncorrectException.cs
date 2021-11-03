using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app.Custom_exceptions
{
    class PasswordIncorrectException : Exception
    {
        public readonly string Message = "Incorrect new password";

        public readonly string Parameters = "password cannot be smaller than 8 or bigger than 25 characters\nhas to have at least 1 lower case , upper case and digit";
        public PasswordIncorrectException (string msj) : base (msj)
        {

        }
        public PasswordIncorrectException ()
        {

        }
        
    }
}
