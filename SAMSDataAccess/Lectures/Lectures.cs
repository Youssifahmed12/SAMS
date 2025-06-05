using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;
using System.Data;

namespace SAMSDataAccess
{
    public static class Lectures
    {
        public static bool AddLecture(int LecNum, int CourseID, int TypeID, DateTime date)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Lectures (LecNum, CourseID, TypeID, Date) VALUES (@LecNum, @CourseID, @TypeID, @Date)", conn))
                {
                    cmd.Parameters.AddWithValue("@LecNum", LecNum);
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@TypeID", TypeID);
                    cmd.Parameters.AddWithValue("@Date", date);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteLecture(int LecID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Lectures WHERE LectureID = @LecID", conn))
                {
                    cmd.Parameters.AddWithValue("@LecID", LecID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool UpdateLecture(int LecID, int LecNum, int CourseID, int TypeID, DateTime date)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Lectures SET LecNum = @LecNum, CourseID = @CourseID, TypeID = @TypeID, Date = @Date WHERE LectureID = @LecID", conn))
                {
                    cmd.Parameters.AddWithValue("@LecID", LecID);
                    cmd.Parameters.AddWithValue("@LecNum", LecNum);
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@TypeID", TypeID);
                    cmd.Parameters.AddWithValue("@Date", date);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static DataTable GetLectures ()
        {

            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Lectures", conn))
                using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

    }
}
