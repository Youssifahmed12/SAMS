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
        public static bool AddCourse(string Name, int CenterID, int NoLecs,int StudentYearID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Courses (Name,CenterID,NoLecs,StudentYearID) VALUES (@Name,@CenterID,@NoLecs,@StudentYearID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@CenterID", CenterID);
                        cmd.Parameters.AddWithValue("@NoLecs", NoLecs);
                        cmd.Parameters.AddWithValue("@StudentYearID", StudentYearID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool UpdateCourse(int CourseID, string Name, int CenterID, int NoLecs,int StudentYearID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Courses SET Name = @Name, CenterID = @CenterID, NoLecs = @NoLecs , StudentYearID = @StudentYearID WHERE CourseID = @CourseID", conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", CourseID);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.Parameters.AddWithValue("@CenterID", CenterID);
                        cmd.Parameters.AddWithValue("@NoLecs", NoLecs);
                        cmd.Parameters.AddWithValue("@StudentYearID", StudentYearID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool DeleteCourse(int CourseID)
        {
            try
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
            catch (Exception)
            {
                return false;
            }
        }
        public static DataTable GetCourses()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(@"SELECT Courses.CourseID, Courses.Name AS CourseName,
                                                                Centers.Name AS CenterName, Courses.NoLecs,StudentYears.Name AS YearName 
                                                                FROM Courses JOIN
                                                                Centers ON Courses.CenterID = Centers.CenterID
                                                                JOIN StudentYears ON Courses.StudentYearID = StudentYears.YearID; ", conn))
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
    }
}