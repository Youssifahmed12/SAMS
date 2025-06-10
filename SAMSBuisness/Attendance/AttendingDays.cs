using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SAMSBuisness.Attendance
{
    public static class AttendingDays
    {
        public static DataTable GetAllAttendingDays()
        {
            return SAMSDataAccess.AttendingDays.GetAllAttendingDays();
        }
        public static DataTable GetAllAttendingDaysForCourse(int CourseID)
        {
            return SAMSDataAccess.AttendingDays.GetAllAttendingDaysForCourse(CourseID);
        }

        public static bool AddAttendanceDay(int CourseID, string Day)
        {
            return SAMSDataAccess.AttendingDays.AddAttendanceDay(CourseID, Day);
        }

        public static bool DeleteAttendanceDay(int AttendanceDayID)
        {
            return SAMSDataAccess.AttendingDays.DeleteAttendanceDay(AttendanceDayID);
        }
        public static bool UpdateAttendanceDay(int AttendanceDay, DateTime NewDay)
        {
            return SAMSDataAccess.AttendingDays.UpdateAttendanceDay(AttendanceDay, NewDay);
        }
    }
}
