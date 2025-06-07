using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMSBuisness.Lectures
{
   public class LecturesTypes
    {
        public static DataTable GetLectureTypes()
        {
            return SAMSDataAccess.LecturesTypes.GetLectureTypes();
        }

        public static bool AddLectureType(string Name)
        {
            return SAMSDataAccess.LecturesTypes.AddLectureType(Name);
        }

        public static bool UpdateLectureType(int TypeID,string Name)
        {
            return SAMSDataAccess.LecturesTypes.UpdateLectureType(TypeID,Name);
        }

        public static bool DeleteLectureType(int TypeID)
        {
            return SAMSDataAccess.LecturesTypes.DeleteLectureType(TypeID);
        }

    }
}
