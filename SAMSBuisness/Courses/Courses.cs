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
        public static bool AddCourse(string Name, int CenterID, int NoLecs, int StudentYearID)
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
    }
}
