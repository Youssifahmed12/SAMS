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
    public partial class frmViewCenters : Form
    {
        public frmViewCenters()
        {
            InitializeComponent();
            UIHelpers.ApplyRoundedStyle(btnAddCenter, btnAddCenter.Height / 2);
        }

        private void frmViewCenters_Load(object sender, EventArgs e)
        {
            LoadData(); 
        }

        private void LoadData()
        {
            try
            {
                DataTable dt = SAMSBuisness.SchoolsAndCenters.Centers.GetAllCenters();
                dgvCenters.DataSource = dt;
                dgvCenters.Font = new Font("Questv1", 18);
                dgvCenters.DefaultCellStyle.Padding = new Padding(5);
                dgvCenters.Columns["CenterID"].Visible = false;
                dgvCenters.Columns["Name"].HeaderText = "اسم السنتر";
                lbNoOfCenters.Text = dt.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading centers: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddCenter_Click(object sender, EventArgs e)
        {

            Form mainForm = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();
            frmAddEditSchoolAndCenter addCenterForm = new frmAddEditSchoolAndCenter(GlobalVariables.ObjectTypes.Center);
            UIHelpers.ShowDialogWithDim(mainForm, addCenterForm);
            LoadData();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mainForm = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();
            frmAddEditSchoolAndCenter editCenterForm = new frmAddEditSchoolAndCenter(GlobalVariables.ObjectTypes.Center, Convert.ToInt32(dgvCenters.SelectedRows[0].Cells["CenterID"].Value), dgvCenters.SelectedRows[0].Cells["Name"].Value.ToString());
            UIHelpers.ShowDialogWithDim(mainForm, editCenterForm);
            LoadData();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form mainForm = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();
            frmDelete frmDelete = new frmDelete(Convert.ToInt32(dgvCenters.SelectedRows[0].Cells["CenterID"].Value), GlobalVariables.ObjectTypes.Center, dgvCenters.SelectedRows[0].Cells["Name"].Value.ToString());
            UIHelpers.ShowDialogWithDim(mainForm, frmDelete);
            LoadData();


        }
    }
}
