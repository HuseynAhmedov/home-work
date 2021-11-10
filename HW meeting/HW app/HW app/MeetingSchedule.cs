using System;
using System.Collections.Generic;
using System.Text;

namespace HW_app
{
    class MeetingSchedule
    {
        public List<Meeting> MeetingsList = new List<Meeting>();

        public void SetMeeting(string newFullname , DateTime newFromDate, DateTime newToDate)
        {
            if (!String.IsNullOrWhiteSpace(newFullname) && newFromDate.Date < newToDate.Date )
            {
                foreach (var item in MeetingsList)
                {
                    if (item.FromDate.CompareTo(newFromDate) < 0 && item.ToDate.CompareTo(newFromDate) > 0)
                    {
                        throw new ExistingMeetingDate();
                    }
                    if (item.FromDate.CompareTo(newToDate) < 0 && item.ToDate.CompareTo(newToDate) > 0)
                    {
                        throw new ExistingMeetingDate();
                        
                    }
                    if (item.FromDate.CompareTo(newFromDate) == 0 && item.ToDate.CompareTo(newToDate) == 0)
                    {
                        throw new ExistingMeetingDate();
                    }
                }
                MeetingsList.Add(new Meeting(newFromDate, newToDate, newFullname));
                return;
            }
            throw new InvalidMeetingParameters();
        }
        
        public int FindMeetingsCount(DateTime searchDate)
        {
            int counter = 0;
            foreach (var item in MeetingsList)
            {
                if (item.FromDate.CompareTo(searchDate) > 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public List<Meeting> FindMeetings(Predicate<Meeting> predicate)
        {
            List<Meeting> meetingsTemp = new List<Meeting>();
            foreach (var item in MeetingsList)
            {
                if (predicate(item))
                {
                    meetingsTemp.Add(item);
                }
            }
            return meetingsTemp;
        }

        public bool ExistMeetingsByName(string searchStr)
        {
            foreach (var item in MeetingsList)
            {
                if (searchStr.Trim().Contains(item.MeetingName))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ExistMeetings(Predicate<Meeting> predicate)
        {
            foreach (var item in MeetingsList)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
