
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

namespace HW_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("az-AZ");

            MeetingSchedule meetingSchedule = new MeetingSchedule();
            meetingSchedule.SetMeeting("test1", Convert.ToDateTime("12/10/2021"), Convert.ToDateTime("15/10/2021"));
            meetingSchedule.SetMeeting("test2", Convert.ToDateTime("16/10/2021"), Convert.ToDateTime("17/10/2021"));
            meetingSchedule.SetMeeting("test3", Convert.ToDateTime("18/10/2021"), Convert.ToDateTime("19/10/2021"));
            meetingSchedule.SetMeeting("test4", Convert.ToDateTime("20/10/2021"), Convert.ToDateTime("24/10/2021"));
            meetingSchedule.SetMeeting("test5", Convert.ToDateTime("25/10/2021"), Convert.ToDateTime("29/10/2021"));

            int a = meetingSchedule.FindMeetingsCount(Convert.ToDateTime("17/10/2021"));
            List<Meeting> meetingsFiltered = meetingSchedule.FindMeetings(delegate (Meeting meeting)
            {
                return meeting.FromDate.CompareTo(Convert.ToDateTime("17/10/2021")) < 0;
            });

            bool b = meetingSchedule.ExistMeetingsByName("test3");

            bool c = meetingSchedule.ExistMeetings(delegate (Meeting meeting)
            {
                return meeting.MeetingName.Contains("test5");
            });

            Console.ReadKey();
        }

       
    }
}
