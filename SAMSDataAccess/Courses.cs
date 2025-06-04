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
    public static class Courses
    {
        public static bool AddCourse(string Name,int CenterID,int NoLecs)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Courses (Name,CenterID,NoLecs) VALUES (@Name,@CenterID,@NoLecs)", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@CenterID", CenterID);
                    cmd.Parameters.AddWithValue("@NoLecs", NoLecs);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static bool UpdateCourse(int CourseID, string Name, int CenterID, int NoLecs)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Courses SET Name = @Name, CenterID = @CenterID, NoLecs = @NoLecs WHERE CourseID = @CourseID", conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@CenterID", CenterID);
                    cmd.Parameters.AddWithValue("@NoLecs", NoLecs);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static bool DeleteCourse(int CourseID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Courses WHERE CourseID = @CourseID", conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static DataTable GetCourses()
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Courses", conn))
                {
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
    }
}
