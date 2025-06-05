using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace SAMSDataAccess
{
    public static class StudentYears
    {
        public static DataTable GetStudentYears()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM StudentYears", conn))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
