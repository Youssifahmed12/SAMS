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
    public partial class frmAddEditSchool : Form
    {
        int ID;
        string SchoolName;
        public frmAddEditSchool(int ID = 0,string SchoolName = "")
        {
            InitializeComponent();
            UIHelpers.ApplyRoundedStyle(btnAdd, btnAdd.Height / 2);
            UIHelpers.ApplyRoundedStyle(btnClose, btnClose.Height / 2);
            this.ID = ID;
            this.SchoolName = SchoolName;
        }

        private void frmAddSchool_Load(object sender, EventArgs e)
        {
            if (ID == 0)
            {
                lbHeaderText.Text = "إضافة مدرسة جديدة";
                btnAdd.Text = "اضف";

            }
            else
            {
                lbHeaderText.Text = "تعديل بيانات المدرسة";
                txtSchoolName.Text = SchoolName;
                btnAdd.Text = "عَدِل";
            }
            lbHeaderText.Left = (lbHeaderText.Parent.ClientSize.Width - lbHeaderText.Width) / 2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtSchoolName.Text))
            {
                MessageBox.Show("من فضلك املأ البيانات المطلوبة", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (SAMSBuisness.SchoolsAndCenters.Schools.Save(ID, txtSchoolName.Text.Trim()))
            {
                MessageBox.Show($"تم {lbHeaderText.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add school. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
