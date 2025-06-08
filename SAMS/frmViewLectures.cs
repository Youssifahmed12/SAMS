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
    public partial class frmViewLectures : Form
    {
        public frmViewLectures()
        {
            InitializeComponent();
            UIHelpers.ApplyRoundedStyle(btnAddLecture, btnAddLecture.Height / 2);
        }

        private void frmViewLectures_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = SAMSBuisness.Lectures.Lectures.GetAllLectures();
                dgvLectures.DataSource = dt;
                dgvLectures.Font = new Font("Questv1", 18);
                dgvLectures.DefaultCellStyle.Padding = new Padding(5);
                dgvLectures.Columns["LecID"].Visible = false;
                dgvLectures.Columns["LecNum"].HeaderText = "رقم المحاضرة";
                dgvLectures.Columns["CourseID"].HeaderText = "رقم المادة";
                dgvLectures.Columns["TypeID"].HeaderText = "نوع المحاضرة";
                dgvLectures.Columns["Date"].HeaderText = "تاريخ المحاضرة";
                lbNoOfSchools.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading lectures: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddLecture_Click(object sender, EventArgs e)
        {
           /* Form mainForm = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();
            if (mainForm != null)
            {
                frmAddEditLecture addLectureForm = new frmAddEditLecture();
                UIHelpers.ShowDialogWithDim(mainForm, addLectureForm);
                LoadData();

            }*/
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();
            frmDelete frmDelete = new frmDelete(Convert.ToInt32(dgvLectures.SelectedRows[0].Cells["LectureID"].Value), GlobalVariables.ObjectTypes.Lecture, dgvLectures.SelectedRows[0].Cells["LecNum"].Value.ToString());
            UIHelpers.ShowDialogWithDim(mainForm, frmDelete);
            LoadData();

        }
    }

}
