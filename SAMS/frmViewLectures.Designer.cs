namespace StudentAttendanceSystem
{
    partial class frmViewLectures
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNoOfSchools = new System.Windows.Forms.Label();
            this.btnAddLecture = new System.Windows.Forms.Button();
            this.dgvLectures = new System.Windows.Forms.DataGridView();
            this.ctxSchoolDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectures)).BeginInit();
            this.ctxSchoolDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Questv1", 14F);
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "عدد المحاضرات :";
            // 
            // lbNoOfSchools
            // 
            this.lbNoOfSchools.AutoSize = true;
            this.lbNoOfSchools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNoOfSchools.Location = new System.Drawing.Point(45, 44);
            this.lbNoOfSchools.Name = "lbNoOfSchools";
            this.lbNoOfSchools.Size = new System.Drawing.Size(18, 20);
            this.lbNoOfSchools.TabIndex = 6;
            this.lbNoOfSchools.Text = "0";
            // 
            // btnAddLecture
            // 
            this.btnAddLecture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLecture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.btnAddLecture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLecture.FlatAppearance.BorderSize = 0;
            this.btnAddLecture.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(97)))), ((int)(((byte)(189)))));
            this.btnAddLecture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLecture.Font = new System.Drawing.Font("Questv1", 14F);
            this.btnAddLecture.ForeColor = System.Drawing.Color.White;
            this.btnAddLecture.Location = new System.Drawing.Point(1063, 25);
            this.btnAddLecture.Name = "btnAddLecture";
            this.btnAddLecture.Size = new System.Drawing.Size(219, 58);
            this.btnAddLecture.TabIndex = 5;
            this.btnAddLecture.Text = "اضافة محاضرة";
            this.btnAddLecture.UseVisualStyleBackColor = false;
            this.btnAddLecture.Click += new System.EventHandler(this.btnAddLecture_Click);
            // 
            // dgvLectures
            // 
            this.dgvLectures.AllowUserToAddRows = false;
            this.dgvLectures.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dgvLectures.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgvLectures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLectures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLectures.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLectures.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLectures.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvLectures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLectures.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvLectures.EnableHeadersVisualStyles = false;
            this.dgvLectures.Location = new System.Drawing.Point(16, 91);
            this.dgvLectures.Name = "dgvLectures";
            this.dgvLectures.ReadOnly = true;
            this.dgvLectures.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLectures.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvLectures.RowHeadersVisible = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvLectures.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvLectures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLectures.Size = new System.Drawing.Size(1266, 670);
            this.dgvLectures.TabIndex = 4;
            // 
            // ctxSchoolDgv
            // 
            this.ctxSchoolDgv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxSchoolDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ctxSchoolDgv.Name = "ctxSchoolDgv";
            this.ctxSchoolDgv.Size = new System.Drawing.Size(181, 70);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditToolStripMenuItem.Text = "عًدٍل";
            this.EditToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteToolStripMenuItem.Text = "مسح";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // frmViewLectures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 787);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNoOfSchools);
            this.Controls.Add(this.btnAddLecture);
            this.Controls.Add(this.dgvLectures);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewLectures";
            this.Text = "frmViewLectures";
            this.Load += new System.EventHandler(this.frmViewLectures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLectures)).EndInit();
            this.ctxSchoolDgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNoOfSchools;
        private System.Windows.Forms.Button btnAddLecture;
        private System.Windows.Forms.DataGridView dgvLectures;
        private System.Windows.Forms.ContextMenuStrip ctxSchoolDgv;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}