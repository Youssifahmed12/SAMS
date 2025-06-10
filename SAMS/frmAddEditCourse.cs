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
    public partial class frmAddEditCourse : Form
    {
       int CourseID;
        public frmAddEditCourse(int courseID = 0)
        {
            InitializeComponent();
            CourseID = courseID;
            UIHelpers.ApplyRoundedStyle(btnAddEdit, btnAddEdit.Height / 2);
            UIHelpers.ApplyRoundedStyle(btnCancel, btnCancel.Height / 2);
        }

        private void frmAddEditCourse_Load(object sender, EventArgs e)
        {
            SetupForm();
            FillComboBoxes();
            //if (CourseID != 0)
            //    LoadCourseData(CourseID);

        }

        private void SetupForm()
        {
            if (CourseID == 0)
            {
                lbHeaderText.Text = "إضافة مجموعة جديدة";
                btnAddEdit.Text = "إضافة";
            }
            else
            {
                lbHeaderText.Text = "تعديل بيانات المجموعة";
                btnAddEdit.Text = "تعديل";
                //LoadCourseData(CourseID);
            }
            lbHeaderText.Left = (lbHeaderText.Parent.ClientSize.Width - lbHeaderText.Width) / 2;
        }

        private void FillComboBoxes()
        {
            try
            {
                // Fill Centers ComboBox
                DataTable dtCenters = SAMSBuisness.SchoolsAndCenters.Centers.GetAllCenters();
                cbCenter.DataSource = dtCenters;
                cbCenter.DisplayMember = "Name";
                cbCenter.ValueMember = "CenterID";

                // Fill Years ComboBox
                DataTable dtYears = SAMSBuisness.Student.StudentYears.GetStudentYears();
                cbYear.DataSource = dtYears;
                cbYear.DisplayMember = "Name";
                cbYear.ValueMember = "YearID";

                cbNoLecs.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
