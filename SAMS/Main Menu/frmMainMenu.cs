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
           SetupSideMenu();
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

        private void button5_Click(object sender, EventArgs e)
        {
            LoadForm(new frmViewCenters());
            ChangeLabelName("السناتر");
        }

        private Color defaultColor = Color.FromArgb(47, 128, 237);
        private Color highlightColor;
        private Color hoverColor;

        private void SetupSideMenu()
        {
            highlightColor = ControlPaint.Light(defaultColor, 0.8f); // lighter shade
            hoverColor = ControlPaint.Light(defaultColor, 0.2f);     // normal hover color

            foreach (Control ctrl in sideMenuPanel.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Click += SideMenuButton_Click;
                    btn.BackColor = defaultColor;
                    btn.ForeColor = Color.White;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;

                    // Set normal hover and pressed colors for all buttons initially
                    btn.FlatAppearance.MouseOverBackColor = hoverColor;
                    btn.FlatAppearance.MouseDownBackColor = ControlPaint.Light(defaultColor, 0.1f);
                }
            }
        }

        private void SideMenuButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                foreach (Control ctrl in sideMenuPanel.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        if (btn == clickedButton)
                        {
                            btn.BackColor = highlightColor;
                            btn.ForeColor = Color.White;

                            // Disable hover/pressed color changes for the selected button
                            btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                            btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
                        }
                        else
                        {
                            // Reset others to default and enable hover effects
                            btn.BackColor = defaultColor;
                            btn.ForeColor = Color.White;

                            btn.FlatAppearance.MouseOverBackColor = hoverColor;
                            btn.FlatAppearance.MouseDownBackColor = ControlPaint.Light(defaultColor, 0.1f);
                        }
                    }
                }
            }
        }

        
    }
}
