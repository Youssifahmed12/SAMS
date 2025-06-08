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

        public static bool AddCenter(string CenterName)
        {
            return SAMSDataAccess.Centers.AddCenter(CenterName);
        }
        public static bool UpdateCenter(int CenterID, string CenterName)
        {
            return SAMSDataAccess.Centers.UpdateCenter(CenterID, CenterName);
        }
        public static bool DeleteCenter(int CenterID)
        {
            return SAMSDataAccess.Centers.DeleteCenter(CenterID);
        }


    }
}
