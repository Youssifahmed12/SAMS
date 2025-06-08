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
    public static class Centers
    {
        public static DataTable GetAllCenters()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Centers", conn))
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
        public static bool AddCenter(string CenterName)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Centers (Name) VALUES (@Name)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", CenterName);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool UpdateCenter(int CenterID, string CenterName)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Centers SET Name = @Name WHERE CenterID = @CenterID", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", CenterName);
                        cmd.Parameters.AddWithValue("@CenterID", CenterID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool DeleteCenter(int CenterID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Centers WHERE CenterID = @CenterID", conn))
                    {
                        cmd.Parameters.AddWithValue("@CenterID", CenterID);
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