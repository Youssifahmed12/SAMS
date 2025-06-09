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
    public partial class frmAddEditSchoolAndCenter : Form
    {
        int ID;
        string SchoolName;
        GlobalVariables.ObjectTypes objType;
        public frmAddEditSchoolAndCenter(GlobalVariables.ObjectTypes objType, int ID = 0, string SchoolOrCenterName = "")
        {
            InitializeComponent();
            UIHelpers.ApplyRoundedStyle(btnAdd, btnAdd.Height / 2);
            UIHelpers.ApplyRoundedStyle(btnClose, btnClose.Height / 2);
            this.ID = ID;
            this.SchoolName = SchoolOrCenterName;
            this.objType = objType;
            txtSchoolName.Text = SchoolOrCenterName;
            btnAdd.Text = ID == 0 ? "إضافة" : "تعديل";
        }

        private void frmAddSchool_Load(object sender, EventArgs e)
        {
            switch (objType)
            {
                case GlobalVariables.ObjectTypes.School:
                    if (ID == 0)
                    {
                        lbHeaderText.Text = "إضافة مدرسة جديدة";
                    }
                    else
                    {
                        lbHeaderText.Text = "تعديل بيانات المدرسة";
                    }
                    break;
                case GlobalVariables.ObjectTypes.Center:
                    lbHeaderText.Text = "إضافة سنتر جديد";
                    if (ID == 0)
                    {
                        lbHeaderText.Text = "إضافة سنتر جديد";
                    }
                    else
                    {
                        lbHeaderText.Text = "تعديل بيانات السنتر";
                    }
                    break;
                default:
                    lbHeaderText.Text = "إضافة مدرسة جديدة";
                    break;
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

            switch (objType)
            {
                case GlobalVariables.ObjectTypes.School:
                    SaveSchool();
                    break;
                case GlobalVariables.ObjectTypes.Center:
                    SaveCenter();
                    break;
                default:
                    break;
            }



        }

        private void SaveSchool()
        {
            if (SAMSBuisness.SchoolsAndCenters.Schools.Save(ID, txtSchoolName.Text.Trim()))
            {
                MessageBox.Show($"تم {lbHeaderText.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("فشل الحفظ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveCenter()
        {
            if (SAMSBuisness.SchoolsAndCenters.Centers.Save(ID, txtSchoolName.Text.Trim()))
            {
                MessageBox.Show($"تم {lbHeaderText.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("فشل الحفظ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
