using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
namespace SAMSDataAccess
{
    public class Attendance
    {
        public static bool AttendStudent(int StudentID, int CourseID, DateTime Date, int StateID, int LectureID, DateTime AttendanceTime)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Attendance (StudentID, CourseID, Date, StateID, LectureID, AttendanceTime) VALUES (@StudentID, @CourseID, @Date, @StateID, @LectureID, @AttendanceTime)", conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        cmd.Parameters.AddWithValue("@CourseID", CourseID);
                        cmd.Parameters.AddWithValue("@Date", Date);
                        cmd.Parameters.AddWithValue("@StateID", StateID);
                        cmd.Parameters.AddWithValue("@LectureID", LectureID);
                        cmd.Parameters.AddWithValue("@AttendanceTime", AttendanceTime);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool UpdateAttendance(int StudentID, int CourseID, DateTime Date, int StateID, int LectureID, DateTime AttendanceTime)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Attendance SET StateID = @StateID, LectureID = @LectureID, AttendanceTime = @AttendanceTime WHERE StudentID = @StudentID AND CourseID = @CourseID AND Date = @Date", conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        cmd.Parameters.AddWithValue("@CourseID", CourseID);
                        cmd.Parameters.AddWithValue("@Date", Date);
                        cmd.Parameters.AddWithValue("@StateID", StateID);
                        cmd.Parameters.AddWithValue("@LectureID", LectureID);
                        cmd.Parameters.AddWithValue("@AttendanceTime", AttendanceTime);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DeleteAttendance(int StudentID, int CourseID, int LectureID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Attendance WHERE StudentID = @StudentID AND CourseID = @CourseID AND LectureID =  @LectureID", conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        cmd.Parameters.AddWithValue("@CourseID", CourseID);
                        cmd.Parameters.AddWithValue("@LectureID", LectureID);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        public static DataTable GetAttendance(int StudentID, int CourseID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Attendance WHERE StudentID = @StudentID AND CourseID = @CourseID ", conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        cmd.Parameters.AddWithValue("@CourseID", CourseID);

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable GetAttendanceByLecture(int LectureID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Attendance WHERE LectureID = @LectureID", conn))
                    {
                        cmd.Parameters.AddWithValue("@LectureID", LectureID);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable GetAttendanceByCourse(int CourseID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Attendance WHERE CourseID = @CourseID", conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", CourseID);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataTable GetAttendanceByStudent(int StudentID)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Attendance WHERE StudentID = @StudentID", conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", StudentID);
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static void MarkMissingStudentsAbsent(int CourseID, DateTime Date)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Attendance (StudentID, CourseID, Date, StateID) SELECT StudentID, @CourseID, @Date, 2 FROM Students WHERE StudentID NOT IN (SELECT StudentID FROM Attendance WHERE CourseID = @CourseID AND Date = @Date)", conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", CourseID);
                        cmd.Parameters.AddWithValue("@Date", Date);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public int GetAttendanceCount(int CourseID,int LecNum,DateTime Date)
        {
           try
            {
                using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
                {
                    conn.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand("SELECT COUNT(*) FROM Attendance WHERE CourseID = @CourseID AND LectureID = @LectureID AND Date = @Date", conn))
                    {
                        cmd.Parameters.AddWithValue("@CourseID", CourseID);
                        cmd.Parameters.AddWithValue("@LectureID", LecNum);
                        cmd.Parameters.AddWithValue("@Date", Date);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

    }
}
