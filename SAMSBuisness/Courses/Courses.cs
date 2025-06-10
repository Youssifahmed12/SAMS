using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SAMSBuisness.Courses
{
    public static class Courses
    {
        private static int? AddCourseData(string Name, int CenterID, int NoLecs, int StudentYearID)
        {
            return SAMSDataAccess.Courses.AddCourse(Name, CenterID, NoLecs,StudentYearID);
        }
        public static bool UpdateCourse(int CourseID, string Name, int CenterID, int NoLecs, int StudentYearID)
        {
            return SAMSDataAccess.Courses.UpdateCourse(CourseID, Name, CenterID, NoLecs, StudentYearID);
        }
        public static bool DeleteCourse(int CourseID)
        {
            return SAMSDataAccess.Courses.DeleteCourse(CourseID);
        }
        public static DataTable GetAllCourses()
        {
            return SAMSDataAccess.Courses.GetCourses();
        }

        public static bool AddCourse(string Name,int CenterID,int NoLecs,int YearID,string LecOne,string LecTwo = "")
        {
            int? newID = AddCourseData(Name, CenterID, NoLecs, YearID);
            bool isAdded = false;
            if (newID.HasValue)
            {
                isAdded = SAMSBuisness.Attendance.AttendingDays.AddAttendanceDay(newID.Value,LecOne);
                if (!string.IsNullOrEmpty(LecTwo))
                {
                   isAdded = SAMSBuisness.Attendance.AttendingDays.AddAttendanceDay(newID.Value, LecTwo);
                }
            }
            return isAdded;
        }

    }
}
