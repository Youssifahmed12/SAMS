using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SAMSBuisness.SchoolsAndCenters
{
    public class Schools
    {
        public static DataTable GetAllSchools()
        {
            return SAMSDataAccess.Schools.GetAllSchools();
        }
        private static bool AddSchool(string SchoolName)
        {
            return SAMSDataAccess.Schools.AddSchool(SchoolName);
        }
        private static bool UpdateSchool(int SchoolID, string SchoolName)
        {
            return SAMSDataAccess.Schools.UpdateSchool(SchoolID, SchoolName);
        }
        public static bool DeleteSchool(int SchoolID)
        {
            return SAMSDataAccess.Schools.DeleteSchool(SchoolID);
        }

        public static bool Save(int ID, string SchoolName)
        {
            if (ID == 0)
            {
                return AddSchool(SchoolName);
            }
            else
            {
                return UpdateSchool(ID, SchoolName);
            }
        }

    }
}
