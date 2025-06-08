using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentAttendanceSystem
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private Form _currentForm;
        private void ChangeLabelName(string NewText)
        {
            lbHeaderText.Text = NewText;
            lbHeaderText.AutoSize = true;
            lbHeaderText.Location = new Point(
                (pnlTop.Width - lbHeaderText.Width) / 2,
                (pnlTop.Height - lbHeaderText.Height) / 2
            );
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        public void LoadForm(Form formToLoad)
        {

            if (_currentForm != null)
                _currentForm.Close();


            _currentForm = formToLoad;
            _currentForm.TopLevel = false;
            _currentForm.FormBorderStyle = FormBorderStyle.None;
            _currentForm.Dock = DockStyle.Fill;


            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(_currentForm);
            _currentForm.Show();
        }


        private void btnSchools_Click(object sender, EventArgs e)
        {
            LoadForm(new SchoolsAndCenters.frmViewSchools());
            ChangeLabelName("المدارس");
        }
    }
}
