namespace StudentAttendanceSystem
{
    partial class frmAddEditCourse
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
            this.lbHeaderText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSchoolName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCenter = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbNoLecs = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHeaderText
            // 
            this.lbHeaderText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbHeaderText.AutoSize = true;
            this.lbHeaderText.Font = new System.Drawing.Font("Questv1", 18F);
            this.lbHeaderText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.lbHeaderText.Location = new System.Drawing.Point(173, 25);
            this.lbHeaderText.Name = "lbHeaderText";
            this.lbHeaderText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbHeaderText.Size = new System.Drawing.Size(154, 32);
            this.lbHeaderText.TabIndex = 4;
            this.lbHeaderText.Text = "اضافة مجموعة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Questv1", 10F);
            this.label1.Location = new System.Drawing.Point(364, 89);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "الاسم :";
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.Font = new System.Drawing.Font("Questv1", 11F);
            this.txtSchoolName.Location = new System.Drawing.Point(103, 84);
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSchoolName.Size = new System.Drawing.Size(245, 32);
            this.txtSchoolName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Questv1", 10F);
            this.label2.Location = new System.Drawing.Point(364, 148);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "السنتر :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Questv1", 10F);
            this.label3.Location = new System.Drawing.Point(364, 254);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "عدد المحاضرات :";
            // 
            // cbCenter
            // 
            this.cbCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCenter.Font = new System.Drawing.Font("Questv1", 11F);
            this.cbCenter.FormattingEnabled = true;
            this.cbCenter.Location = new System.Drawing.Point(103, 147);
            this.cbCenter.Name = "cbCenter";
            this.cbCenter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCenter.Size = new System.Drawing.Size(245, 28);
            this.cbCenter.TabIndex = 10;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Questv1", 11F);
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbYear.Location = new System.Drawing.Point(103, 199);
            this.cbYear.Name = "cbYear";
            this.cbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbYear.Size = new System.Drawing.Size(245, 28);
            this.cbYear.TabIndex = 11;
            // 
            // cbNoLecs
            // 
            this.cbNoLecs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoLecs.Font = new System.Drawing.Font("Questv1", 11F);
            this.cbNoLecs.FormattingEnabled = true;
            this.cbNoLecs.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbNoLecs.Location = new System.Drawing.Point(103, 253);
            this.cbNoLecs.Name = "cbNoLecs";
            this.cbNoLecs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbNoLecs.Size = new System.Drawing.Size(245, 28);
            this.cbNoLecs.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Questv1", 10F);
            this.label4.Location = new System.Drawing.Point(364, 203);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "السنة الدراسية :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Questv1", 10F);
            this.label5.Location = new System.Drawing.Point(364, 307);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "المحاضرة الاولى :";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Questv1", 11F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(103, 305);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox4.Size = new System.Drawing.Size(245, 28);
            this.comboBox4.TabIndex = 15;
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Questv1", 11F);
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(103, 356);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox5.Size = new System.Drawing.Size(245, 28);
            this.comboBox5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Questv1", 10F);
            this.label6.Location = new System.Drawing.Point(364, 357);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(103, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "المحاضرة الثانية :";
            // 
            // btnAddEdit
            // 
            this.btnAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(128)))), ((int)(((byte)(237)))));
            this.btnAddEdit.FlatAppearance.BorderSize = 0;
            this.btnAddEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEdit.Font = new System.Drawing.Font("Questv1", 14F);
            this.btnAddEdit.ForeColor = System.Drawing.Color.White;
            this.btnAddEdit.Location = new System.Drawing.Point(261, 412);
            this.btnAddEdit.Name = "btnAddEdit";
            this.btnAddEdit.Size = new System.Drawing.Size(128, 46);
            this.btnAddEdit.TabIndex = 18;
            this.btnAddEdit.Text = "اضف";
            this.btnAddEdit.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Questv1", 14F);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(105, 412);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 46);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "الغاء";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAddEditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 484);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbNoLecs);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbCenter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSchoolName);
            this.Controls.Add(this.lbHeaderText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditCourse";
            this.Text = "frmAddEditCourse";
            this.Load += new System.EventHandler(this.frmAddEditCourse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHeaderText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSchoolName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCenter;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.ComboBox cbNoLecs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddEdit;
        private System.Windows.Forms.Button btnCancel;
    }
}