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
        DataTable dt  = new DataTable();
        public frmViewSchools()
        {
            InitializeComponent();
            UIHelpers.ApplyRoundedStyle(btnAddSchool,btnAddSchool.Height/2);
        }

        private void LoadData()
        {
            try
            {
                dt = SAMSBuisness.SchoolsAndCenters.Schools.GetAllSchools();
                dgvSchools.DataSource = dt;
                dgvSchools.Font = new Font("Questv1",18);
                dgvSchools.DefaultCellStyle.Padding = new Padding(5);
                dgvSchools.Columns["SchoolID"].Visible = false;
                dgvSchools.Columns["Name"].HeaderText = "اسم المدرسة";
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
        
        

    }
}
