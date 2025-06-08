namespace StudentAttendanceSystem
{
    partial class frmViewCenters
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNoOfCenters = new System.Windows.Forms.Label();
            this.btnAddCenter = new System.Windows.Forms.Button();
            this.dgvCenters = new System.Windows.Forms.DataGridView();
            this.ctxCenterlDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenters)).BeginInit();
            this.ctxCenterlDgv.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Questv1", 14F);
            this.label1.Location = new System.Drawing.Point(70, 39);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "عدد السناتر :";
            // 
            // lbNoOfCenters
            // 
            this.lbNoOfCenters.AutoSize = true;
            this.lbNoOfCenters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNoOfCenters.Location = new System.Drawing.Point(45, 44);
            this.lbNoOfCenters.Name = "lbNoOfCenters";
            this.lbNoOfCenters.Size = new System.Drawing.Size(18, 20);
            this.lbNoOfCenters.TabIndex = 6;
            this.lbNoOfCenters.Text = "0";
            // 
            // btnAddCenter
            // 
            this.btnAddCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.btnAddCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCenter.FlatAppearance.BorderSize = 0;
            this.btnAddCenter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(97)))), ((int)(((byte)(189)))));
            this.btnAddCenter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCenter.Font = new System.Drawing.Font("Questv1", 14F);
            this.btnAddCenter.ForeColor = System.Drawing.Color.White;
            this.btnAddCenter.Location = new System.Drawing.Point(1063, 25);
            this.btnAddCenter.Name = "btnAddCenter";
            this.btnAddCenter.Size = new System.Drawing.Size(219, 58);
            this.btnAddCenter.TabIndex = 5;
            this.btnAddCenter.Text = "اضافة سنتر";
            this.btnAddCenter.UseVisualStyleBackColor = false;
            this.btnAddCenter.Click += new System.EventHandler(this.btnAddCenter_Click);
            // 
            // dgvCenters
            // 
            this.dgvCenters.AllowUserToAddRows = false;
            this.dgvCenters.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.dgvCenters.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCenters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCenters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCenters.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCenters.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCenters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCenters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCenters.ContextMenuStrip = this.ctxCenterlDgv;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCenters.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCenters.EnableHeadersVisualStyles = false;
            this.dgvCenters.Location = new System.Drawing.Point(16, 91);
            this.dgvCenters.Name = "dgvCenters";
            this.dgvCenters.ReadOnly = true;
            this.dgvCenters.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCenters.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCenters.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SkyBlue;
            this.dgvCenters.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCenters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCenters.Size = new System.Drawing.Size(1266, 670);
            this.dgvCenters.TabIndex = 4;
            // 
            // ctxCenterlDgv
            // 
            this.ctxCenterlDgv.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctxCenterlDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.ctxCenterlDgv.Name = "ctxSchoolDgv";
            this.ctxCenterlDgv.Size = new System.Drawing.Size(181, 70);
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
            // frmViewCenters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 787);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNoOfCenters);
            this.Controls.Add(this.btnAddCenter);
            this.Controls.Add(this.dgvCenters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewCenters";
            this.Text = "frmViewCenters";
            this.Load += new System.EventHandler(this.frmViewCenters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCenters)).EndInit();
            this.ctxCenterlDgv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNoOfCenters;
        private System.Windows.Forms.Button btnAddCenter;
        private System.Windows.Forms.DataGridView dgvCenters;
        private System.Windows.Forms.ContextMenuStrip ctxCenterlDgv;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}