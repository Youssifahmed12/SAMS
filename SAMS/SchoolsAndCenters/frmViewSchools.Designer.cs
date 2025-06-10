namespace StudentAttendanceSystem.SchoolsAndCenters
{
    partial class frmViewSchools
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvSchools = new System.Windows.Forms.DataGridView();
            this.ctxSchoolDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.lbNoOfSchools = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchools)).BeginInit();
            this.ctxSchoolDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSchools
            // 
            this.dgvSchools.AllowUserToAddRows = false;
            this.dgvSchools.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dgvSchools.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSchools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSchools.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchools.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchools.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchools.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSchools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchools.ContextMenuStrip = this.ctxSchoolDgv;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSchools.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSchools.EnableHeadersVisualStyles = false;
            this.dgvSchools.Location = new System.Drawing.Point(22, 118);
            this.dgvSchools.Name = "dgvSchools";
            this.dgvSchools.ReadOnly = true;
            this.dgvSchools.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSchools.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSchools.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvSchools.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSchools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSchools.Size = new System.Drawing.Size(1266, 670);
            this.dgvSchools.TabIndex = 0;
            // 
            // ctxSchoolDgv
            // 
            this.ctxSchoolDgv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxSchoolDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ctxSchoolDgv.Name = "ctxSchoolDgv";
            this.ctxSchoolDgv.Size = new System.Drawing.Size(99, 48);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.EditToolStripMenuItem.Text = "عًدٍل";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.DeleteToolStripMenuItem.Text = "مسح";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSchool.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.btnAddSchool.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSchool.FlatAppearance.BorderSize = 0;
            this.btnAddSchool.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(97)))), ((int)(((byte)(189)))));
            this.btnAddSchool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSchool.Font = new System.Drawing.Font("Questv1", 14F);
            this.btnAddSchool.ForeColor = System.Drawing.Color.White;
            this.btnAddSchool.Location = new System.Drawing.Point(1069, 52);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(219, 58);
            this.btnAddSchool.TabIndex = 1;
            this.btnAddSchool.Text = "اضافة مدرسة";
            this.btnAddSchool.UseVisualStyleBackColor = false;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            // 
            // lbNoOfSchools
            // 
            this.lbNoOfSchools.AutoSize = true;
            this.lbNoOfSchools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNoOfSchools.Location = new System.Drawing.Point(51, 71);
            this.lbNoOfSchools.Name = "lbNoOfSchools";
            this.lbNoOfSchools.Size = new System.Drawing.Size(18, 20);
            this.lbNoOfSchools.TabIndex = 2;
            this.lbNoOfSchools.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Questv1", 14F);
            this.label1.Location = new System.Drawing.Point(76, 66);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "عدد المدارس :";
            // 
            // frmViewSchools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 826);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNoOfSchools);
            this.Controls.Add(this.btnAddSchool);
            this.Controls.Add(this.dgvSchools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewSchools";
            this.Text = "View Schools";
            this.Load += new System.EventHandler(this.frmViewSchools_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchools)).EndInit();
            this.ctxSchoolDgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchools;
        private System.Windows.Forms.Button btnAddSchool;
        private System.Windows.Forms.Label lbNoOfSchools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip ctxSchoolDgv;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}