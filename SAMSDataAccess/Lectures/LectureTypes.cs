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
    public static class LectureTypes
    {
        public static DataTable GetLectureTypes()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM LectureTypes", conn))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
        public static bool AddLectureType(string Name)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO LectureTypes (Name) VALUES (@Name)", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static bool UpdateLectureType(int TypeID, string Name)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE LectureTypes SET Name = @Name WHERE TypeID = @TypeID", conn))
                {
                    cmd.Parameters.AddWithValue("@TypeID", TypeID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteLectureType(int TypeID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM LectureTypes WHERE TypeID = @TypeID", conn))
                {
                    cmd.Parameters.AddWithValue("@TypeID", TypeID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
