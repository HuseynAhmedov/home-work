using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app.Custom_exceptions
{
    class InvalidUserNameException : Exception
    {
        public readonly string Message = "Invalid user name";

        public readonly string Parameters = "Username cannot be smaller than 6 or bigger than 25 characters";

        public InvalidUserNameException(string msj) : base(msj)
        {

        }
        public InvalidUserNameException()
        {

        }
    }
}
