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
    public partial class frmAddSchool : Form
    {
        public frmAddSchool()
        {
            InitializeComponent();
            UIHelpers.ApplyRoundedStyle(btnAdd, btnAdd.Height / 2);
            UIHelpers.ApplyRoundedStyle(btnClose, btnClose.Height / 2);
        }

        private void frmAddSchool_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSchoolName.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SAMSBuisness.SchoolsAndCenters.Schools.AddSchool(txtSchoolName.Text.Trim()))
            {
                MessageBox.Show("School added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add school. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
