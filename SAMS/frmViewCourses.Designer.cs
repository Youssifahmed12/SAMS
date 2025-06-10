namespace StudentAttendanceSystem
{
    partial class frmViewCourses
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNoOfCourses = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCourse.FlatAppearance.BorderSize = 0;
            this.btnAddCourse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(97)))), ((int)(((byte)(189)))));
            this.btnAddCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCourse.Font = new System.Drawing.Font("Questv1", 14F);
            this.btnAddCourse.ForeColor = System.Drawing.Color.White;
            this.btnAddCourse.Location = new System.Drawing.Point(1069, 52);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(219, 58);
            this.btnAddCourse.TabIndex = 2;
            this.btnAddCourse.Text = "اضافة مجموعة";
            this.btnAddCourse.UseVisualStyleBackColor = false;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dgvCourses.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCourses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCourses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCourses.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCourses.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCourses.EnableHeadersVisualStyles = false;
            this.dgvCourses.Location = new System.Drawing.Point(22, 118);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCourses.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCourses.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvCourses.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCourses.Size = new System.Drawing.Size(1266, 670);
            this.dgvCourses.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Questv1", 14F);
            this.label1.Location = new System.Drawing.Point(77, 68);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "عدد المجموعات :";
            // 
            // lbNoOfCourses
            // 
            this.lbNoOfCourses.AutoSize = true;
            this.lbNoOfCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNoOfCourses.Location = new System.Drawing.Point(52, 73);
            this.lbNoOfCourses.Name = "lbNoOfCourses";
            this.lbNoOfCourses.Size = new System.Drawing.Size(18, 20);
            this.lbNoOfCourses.TabIndex = 4;
            this.lbNoOfCourses.Text = "0";
            // 
            // frmViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 826);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNoOfCourses);
            this.Controls.Add(this.dgvCourses);
            this.Controls.Add(this.btnAddCourse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewCourses";
            this.Text = "frmViewCourses";
            this.Load += new System.EventHandler(this.frmViewCourses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNoOfCourses;
    }
}