using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class frmViewCourses : Form
    {
        public frmViewCourses()
        {
            InitializeComponent();
            UIHelpers.ApplyRoundedStyle(btnAddCourse, btnAddCourse.Height / 2);
        }

        private void frmViewCourses_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                DataTable dt = SAMSBuisness.Courses.Courses.GetAllCourses();
                dgvCourses.DataSource = dt;
                dgvCourses.Font = new Font("Questv1", 18);
                dgvCourses.DefaultCellStyle.Padding = new Padding(5);
                dgvCourses.Columns["CourseID"].Visible = false;
                dgvCourses.Columns["CourseName"].HeaderText = "اسم المادة";
                dgvCourses.Columns["CenterName"].HeaderText = "اسم السنتر";
                dgvCourses.Columns["YearName"].HeaderText = "السنة الدراسية";
                dgvCourses.Columns["NoLecs"].HeaderText = "عدد المحاضرات";
                dgvCourses.Columns["DaysOfAttendance"].HeaderText = "أيام الحضور";

                lbNoOfCourses.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCourse_Click(object sender, EventArgs e)
        {

            Form mainForm = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();

            frmAddEditCourse addEditCourseForm = new frmAddEditCourse();
            UIHelpers.ShowDialogWithDim(mainForm,addEditCourseForm);
            LoadData();
        }
    }
}
