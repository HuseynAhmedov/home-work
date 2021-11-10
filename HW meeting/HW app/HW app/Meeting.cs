using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class Meeting
    {
        public DateTime FromDate { get; private set; }
        public DateTime ToDate { get; private set; }
        public string MeetingName { get; set; }

        public Meeting(DateTime fromDate, DateTime toDate, string meetingName)
        {
            this.FromDate = fromDate;
            this.ToDate = toDate;
            this.MeetingName = meetingName;
        }
    }
}
