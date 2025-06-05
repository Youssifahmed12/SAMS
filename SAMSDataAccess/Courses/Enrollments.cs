using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Configuration;

namespace SAMSDataAccess
{
    public static class Enrollments
    {
        public static DataTable GetEnrollmentsForStudent(int StudentID)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT Name FROM Courses Join Enrollments on Courses.CourseID = Enrollments.CourseID Where StudentID = @StudentID", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
        
        public static DataTable GetReigesteredStudentsForCourse(int CourseID)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT Name FROM Students Join Enrollments on Students.StudentID = Enrollments.StudentID Where CourseID = @CourseID", conn))
                {
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public static bool RegisterStudentToCourse(int StudentID, int CourseID, DateTime RegDate)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Enrollments (StudentID, CourseID, RegDate) VALUES (@StudentID, @CourseID, @RegDate)", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    cmd.Parameters.AddWithValue("@CourseID", CourseID);
                    cmd.Parameters.AddWithValue("@RegDate", RegDate);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }


    }
}
