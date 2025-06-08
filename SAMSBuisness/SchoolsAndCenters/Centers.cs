using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMSBuisness.SchoolsAndCenters
{
    public class Centers
    {
        public static DataTable GetAllCenters()
        {
            return SAMSDataAccess.Centers.GetAllCenters();
        }

        private static bool AddCenter(string CenterName)
        {
            return SAMSDataAccess.Centers.AddCenter(CenterName);
        }
        private static bool UpdateCenter(int CenterID, string CenterName)
        {
            return SAMSDataAccess.Centers.UpdateCenter(CenterID, CenterName);
        }
        public static bool DeleteCenter(int CenterID)
        {
            return SAMSDataAccess.Centers.DeleteCenter(CenterID);
        }

        public static bool Save(int CenterID, string CenterName)
        {
            if (CenterID == 0)
            {
               return AddCenter(CenterName);
            }
            else
            {
               return UpdateCenter(CenterID, CenterName);
            }
        }


    }
}
