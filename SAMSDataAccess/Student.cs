using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAMSDataAccess
{
    public static class Student
    {
        public static bool AddStudent(string Name,string PersonalPhone,string ParentPhone,int Year,int CenterID,int SchoolID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("INSERT INTO Students (Name,PersonalPhone,ParentPhone,Year,CenterID,SchoolID) VALUES (@Name,@PersonalPhone,@ParentPhone,@Year,@CenterID,@SchoolID)", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@PersonalPhone", PersonalPhone);
                    cmd.Parameters.AddWithValue("@ParentPhone", ParentPhone);
                    cmd.Parameters.AddWithValue("@Year", Year);
                    cmd.Parameters.AddWithValue("@CenterID", CenterID);
                    cmd.Parameters.AddWithValue("@SchoolID", SchoolID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static bool UpdateStudent(int StudentID, string Name, string PersonalPhone, string ParentPhone, int Year, int CenterID, int SchoolID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("UPDATE Students SET Name = @Name, PersonalPhone = @PersonalPhone, ParentPhone = @ParentPhone, Year = @Year, CenterID = @CenterID, SchoolID = @SchoolID WHERE StudentID = @StudentID", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@PersonalPhone", PersonalPhone);
                    cmd.Parameters.AddWithValue("@ParentPhone", ParentPhone);
                    cmd.Parameters.AddWithValue("@Year", Year);
                    cmd.Parameters.AddWithValue("@CenterID", CenterID);
                    cmd.Parameters.AddWithValue("@SchoolID", SchoolID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static bool DeleteStudent(int StudentID)
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Students WHERE StudentID = @StudentID", conn))
                {
                    cmd.Parameters.AddWithValue("@StudentID", StudentID);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public static DataTable GetStudents()
        {
            using (SQLiteConnection conn = new SQLiteConnection(ConfigurationManager.ConnectionStrings["SAMSDB"].ConnectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand("SELECT * FROM Students", conn))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
