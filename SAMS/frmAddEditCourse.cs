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
            cbLecTwo.Enabled = false;
            cbLecTwo.SelectedIndex = -1;
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

                // Fill Lec Day ComboBox
                cbLecOne.DataSource = GlobalVariables.WeekDays.Keys.ToList();
                cbLecTwo.DataSource = GlobalVariables.WeekDays.Keys.ToList();

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

        private void btnAddEdit_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text.Trim();
            int CenterID = Convert.ToInt32(cbCenter.SelectedValue);
            int YearID = Convert.ToInt32(cbYear.SelectedValue);
            int NoLecs = Convert.ToInt32(cbNoLecs.SelectedItem);
            string LecOne = cbLecOne.SelectedItem.ToString();
            string LecTwo = "";
            if (NoLecs == 2)
            {
                LecTwo = cbLecTwo.SelectedItem.ToString();
            }

            if (SAMSBuisness.Courses.Courses.AddCourse(Name, CenterID, NoLecs, YearID, LecOne, LecTwo))
            {
                MessageBox.Show("تمت إضافة المجموعة بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء إضافة المجموعة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbNoLecs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNoLecs.SelectedItem.ToString() == "2")
            {
                cbLecTwo.Enabled = true;
            }
            else
            {
                cbLecTwo.Enabled = false;
                cbLecTwo.SelectedIndex = -1; // Reset selection if not applicable
            }
        }
    }
}