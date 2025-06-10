using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem.SchoolsAndCenters
{
    public partial class frmViewSchools : Form
    {
        DataTable dt = new DataTable();
        public frmViewSchools()
        {
            InitializeComponent();
            UIHelpers.ApplyRoundedStyle(btnAddSchool, btnAddSchool.Height / 2);
        }

        private void LoadData()
        {
            try
            {
                dt = SAMSBuisness.SchoolsAndCenters.Schools.GetAllSchools();
                dgvSchools.DataSource = dt;
                dgvSchools.Font = new Font("Questv1", 18);
                dgvSchools.DefaultCellStyle.Padding = new Padding(5);
                dgvSchools.Columns["SchoolID"].Visible = false;
                dgvSchools.Columns["Name"].HeaderText = "اسم المدرسة";
                lbNoOfSchools.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading schools: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmViewSchools_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {

            Form mainForm = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();
            frmAddEditSchoolAndCenter addSchoolForm = new frmAddEditSchoolAndCenter(GlobalVariables.ObjectTypes.School);
            UIHelpers.ShowDialogWithDim(mainForm, addSchoolForm);
            LoadData();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();
            frmAddEditSchoolAndCenter editSchoolForm = new frmAddEditSchoolAndCenter(GlobalVariables.ObjectTypes.School,Convert.ToInt32(dgvSchools.SelectedRows[0].Cells["SchoolID"].Value), dgvSchools.SelectedRows[0].Cells["Name"].Value.ToString());
            UIHelpers.ShowDialogWithDim(mainForm, editSchoolForm);
            LoadData();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();
            frmDelete frmDelete = new frmDelete(Convert.ToInt32(dgvSchools.SelectedRows[0].Cells["SchoolID"].Value), GlobalVariables.ObjectTypes.School, dgvSchools.SelectedRows[0].Cells["Name"].Value.ToString());
            UIHelpers.ShowDialogWithDim(mainForm, frmDelete);
            LoadData();
        }
    }
}
