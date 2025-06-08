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
    public static class Schools
    {
        public static DataTable GetAllSchools()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Schools", conn))
                    {
                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                }
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool AddSchool(string SchoolName)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Schools (Name) VALUES (@Name)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", SchoolName);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool UpdateSchool(int SchoolID, string SchoolName)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Schools SET Name = @Name WHERE SchoolID = @SchoolID", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", SchoolName);
                        cmd.Parameters.AddWithValue("@SchoolID", SchoolID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool DeleteSchool(int SchoolID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Schools WHERE SchoolID = @SchoolID", conn))
                    {
                        cmd.Parameters.AddWithValue("@SchoolID", SchoolID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}