using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SAMSBuisness.Student
{
    public static class StudentYears
    {
        public static DataTable GetStudentYears()
        {
            return SAMSDataAccess.StudentYears.GetStudentYears();
        }
    }
}