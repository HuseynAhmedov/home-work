using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class InvalidMeetingParameters : Exception
    {
        public readonly string message = " Invalid meeting parameters";

        public readonly string parameters = " From date cannot be bigger than To date\n Meeting name cannot be null or all white space";
        public InvalidMeetingParameters(string message) : base(message)
        {

        }
        public InvalidMeetingParameters()
        {

        }
    }

    class ExistingMeetingDate : Exception
    {
        public readonly string message = "Meeting exits by given date parameters";
    }

}
