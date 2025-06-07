using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SAMSBuisness.Lectures
{
    public class Lectures
    {
        public static DataTable GetAllLectures()
        {
            return SAMSDataAccess.Lectures.GetLectures();
        }
        
        public static bool AddLecture(int LecNum, int CourseID, int TypeID, DateTime date, float TeacherCut, float CenterCut)
        {
            return SAMSDataAccess.Lectures.AddLecture(LecNum, CourseID, TypeID, date, TeacherCut, CenterCut);
        }

        public static bool UpdateLecture(int LecID, int LecNum, int CourseID, int TypeID, DateTime date, float TeacherCut, float CenterCut)
        {
            return SAMSDataAccess.Lectures.UpdateLecture(LecID, LecNum, CourseID, TypeID, date, TeacherCut, CenterCut);
        }
        public static bool DeleteLecture(int LecID)
        {
            return SAMSDataAccess.Lectures.DeleteLecture(LecID);
        }
    }
}
