using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SAMSDataAccess
{
    public static class AttendingDays
    {
        public static DataTable GetAllAttendingDays()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    DataTable dt = new DataTable();
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM AttendingDays", conn))
                    {
                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    return dt;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static DataTable GetAllAttendingDaysForCourse(int CourseID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    DataTable dt = new DataTable();
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM AttendingDays WHERE CourseID = @CourseID", conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", CourseID);
                        using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                    }
                    return dt;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool AddAttendanceDay(int CourseID, DateTime Day)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO AttendingDays (CourseID, Day) VALUES (@CourseID, @Day)", conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", CourseID);
                        cmd.Parameters.AddWithValue("@Day", Day);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DeleteAttendanceDay(int AttendanceDayID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM AttendingDays WHERE AttendingDayID = @AttendingDayID", conn))
                    {
                        cmd.Parameters.AddWithValue("@AttendingDayID", AttendanceDayID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool UpdateAttendanceDay(int AttendanceDayID, DateTime Day)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("UPDATE AttendingDays SET Day = @Day WHERE AttendingDayID = @AttendingDayID", conn))
                    {
                        cmd.Parameters.AddWithValue("@AttendingDayID", AttendanceDayID);
                        cmd.Parameters.AddWithValue("@Day", Day);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}