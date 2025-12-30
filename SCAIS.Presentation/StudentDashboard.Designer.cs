namespace SCAIS.Presentation
{
    partial class StudentDashboard
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
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.lblSemester = new System.Windows.Forms.Label();
            this.lblSelectedCount = new System.Windows.Forms.Label();
            this.btnSubmitPlan = new System.Windows.Forms.Button();
            this.clbCourses = new System.Windows.Forms.CheckedListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmbYear.Location = new System.Drawing.Point(133, 50);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 17;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.Location = new System.Drawing.Point(13, 55);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(44, 16);
            this.lblYear.TabIndex = 16;
            this.lblYear.Text = "Year:";
            // 
            // cmbSemester
            // 
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbSemester.Location = new System.Drawing.Point(133, 98);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(121, 21);
            this.cmbSemester.TabIndex = 15;
            // 
            // lblSemester
            // 
            this.lblSemester.AutoSize = true;
            this.lblSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSemester.Location = new System.Drawing.Point(13, 99);
            this.lblSemester.Name = "lblSemester";
            this.lblSemester.Size = new System.Drawing.Size(77, 16);
            this.lblSemester.TabIndex = 14;
            this.lblSemester.Text = "Semester:";
            // 
            // lblSelectedCount
            // 
            this.lblSelectedCount.AutoSize = true;
            this.lblSelectedCount.Location = new System.Drawing.Point(323, 266);
            this.lblSelectedCount.Name = "lblSelectedCount";
            this.lblSelectedCount.Size = new System.Drawing.Size(78, 13);
            this.lblSelectedCount.TabIndex = 13;
            this.lblSelectedCount.Text = "Selected: 0 / 4";
            this.lblSelectedCount.Click += new System.EventHandler(this.lblSelectedCount_Click);
            // 
            // btnSubmitPlan
            // 
            this.btnSubmitPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitPlan.Location = new System.Drawing.Point(276, 297);
            this.btnSubmitPlan.Name = "btnSubmitPlan";
            this.btnSubmitPlan.Size = new System.Drawing.Size(125, 45);
            this.btnSubmitPlan.TabIndex = 12;
            this.btnSubmitPlan.Text = "Submit Plan";
            this.btnSubmitPlan.UseVisualStyleBackColor = true;
            this.btnSubmitPlan.Click += new System.EventHandler(this.btnSubmitPlan_Click);
            // 
            // clbCourses
            // 
            this.clbCourses.CheckOnClick = true;
            this.clbCourses.FormattingEnabled = true;
            this.clbCourses.Location = new System.Drawing.Point(257, 139);
            this.clbCourses.Name = "clbCourses";
            this.clbCourses.Size = new System.Drawing.Size(210, 124);
            this.clbCourses.TabIndex = 11;
            this.clbCourses.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbCourses_ItemCheck);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(13, 139);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(226, 16);
            this.lblInfo.TabIndex = 10;
            this.lblInfo.Text = "Eligible Courses (tick to select):";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.Location = new System.Drawing.Point(12, 9);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(166, 20);
            this.lblStudent.TabIndex = 9;
            this.lblStudent.Text = "Student Dashboard";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.cmbSemester);
            this.Controls.Add(this.lblSemester);
            this.Controls.Add(this.lblSelectedCount);
            this.Controls.Add(this.btnSubmitPlan);
            this.Controls.Add(this.clbCourses);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblStudent);
            this.Name = "StudentDashboard";
            this.Text = "StudentDashboard";
            this.Load += new System.EventHandler(this.StudentDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label lblSemester;
        private System.Windows.Forms.Label lblSelectedCount;
        private System.Windows.Forms.Button btnSubmitPlan;
        private System.Windows.Forms.CheckedListBox clbCourses;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}