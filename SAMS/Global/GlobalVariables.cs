using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendanceSystem
{
    public static class GlobalVariables
    {
        public static Dictionary<string,int> WeekDays = new Dictionary<string, int>()
        {
            { "السبت", 1 },
            { "الأحد", 2 },
            { "الإثنين", 3 },
            { "الثلاثاء", 4 },
            { "الأربعاء", 5 },
            { "الخميس", 6 },
            { "الجمعة", 7 }
        };
        public enum ObjectTypes
        {
            School,
            Center,
            Student,
            StudentYears,
            Lecture,
            LectureType,
            Course,
            Enrollment,
            Attendance,
            AttendanceState,
            AttendingDays,
        }
    }
}
