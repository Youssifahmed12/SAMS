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
    public partial class frmDelete : Form
    {
        int ID;
        GlobalVariables.ObjectTypes Type;
        string ObjName;
        public frmDelete(int ID, GlobalVariables.ObjectTypes Type, string ObjName)
        {
            InitializeComponent();
            UIHelpers.ApplyRoundedStyle(btnCancel, btnCancel.Height / 2);
            UIHelpers.ApplyRoundedStyle(btnConfirm, btnConfirm.Height / 2);
            this.ID = ID;
            this.Type = Type;
            this.ObjName = ObjName;


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool RedirectToAppropiateDeletetion()
        {
            bool isDeleted = false;
            switch (Type)
            {
                case GlobalVariables.ObjectTypes.School:
                    isDeleted = SAMSBuisness.SchoolsAndCenters.Schools.DeleteSchool(ID);
                    break;
                case GlobalVariables.ObjectTypes.Center:
                    SAMSBuisness.SchoolsAndCenters.Centers.DeleteCenter(ID);
                    break;
                case GlobalVariables.ObjectTypes.Student:
                    break;
                case GlobalVariables.ObjectTypes.StudentYears:
                    break;
                case GlobalVariables.ObjectTypes.Lecture:
                    SAMSBuisness.Lectures.Lectures.DeleteLecture(ID);
                    break;
                case GlobalVariables.ObjectTypes.LectureType:
                    break;
                case GlobalVariables.ObjectTypes.Course:

                    break;
                case GlobalVariables.ObjectTypes.Enrollment:
                    break;
                case GlobalVariables.ObjectTypes.Attendance:
                    break;
                case GlobalVariables.ObjectTypes.AttendanceState:
                    break;
                case GlobalVariables.ObjectTypes.AttendingDays:
                    break;
            }
            return isDeleted;
        }

        private void AdjustLabelText()
        {
            switch (Type)
            {
                case GlobalVariables.ObjectTypes.School:
                    lbDeleteItem.Text = "سيتم مسح المدرسة: " + ObjName;
                    break;
                case GlobalVariables.ObjectTypes.Center:
                    lbDeleteItem.Text = "سيتم مسح السنتر: " + ObjName;
                    break;
                case GlobalVariables.ObjectTypes.Student:
                    lbDeleteItem.Text = "سيتم مسح الطالب: " + ObjName;
                    break;
                case GlobalVariables.ObjectTypes.StudentYears:
                    lbDeleteItem.Text = "سيتم مسح السنة الدراسية: " + ObjName;
                    break;
                case GlobalVariables.ObjectTypes.Lecture:
                    lbDeleteItem.Text = "سيتم مسح المحاضرة: " + ObjName;
                    break;
                case GlobalVariables.ObjectTypes.LectureType:
                    lbDeleteItem.Text = "سيتم مسح نوع المحاضرة: " + ObjName;
                    break;
                case GlobalVariables.ObjectTypes.Course:
                    lbDeleteItem.Text = "سيتم مسح المادة: " + ObjName;
                    break;
                case GlobalVariables.ObjectTypes.Enrollment:
                    lbDeleteItem.Text = "سيتم مسح التسجيل: " + ObjName;
                    break;
                case GlobalVariables.ObjectTypes.Attendance:
                    lbDeleteItem.Text = "سيتم مسح الحضور للطالب: " + ObjName;
                    break;
                case GlobalVariables.ObjectTypes.AttendanceState:
                    lbDeleteItem.Text = "سيتم مسح حالة الحضور: " + ObjName;
                    break;
                case GlobalVariables.ObjectTypes.AttendingDays:
                    lbDeleteItem.Text = "سيتم مسح يوم الحضور: " + ObjName;
                    break;
                default:
                    lbDeleteItem.Text = "سيتم مسح العنصر: " + ObjName;
                    break;
            }
        }
        private void frmDelete_Load(object sender, EventArgs e)
        {
            AdjustLabelText();
            lbDeleteItem.AutoSize = true; // make it resize to fit new text
            lbDeleteItem.Left = (lbDeleteItem.Parent.ClientSize.Width - lbDeleteItem.Width) / 2;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            
            bool isDeleted = RedirectToAppropiateDeletetion();
            if (isDeleted)
            {
                MessageBox.Show("تم مسح العنصر بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("حدث خطأ أثناء مسح العنصر", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
