namespace SCAIS.Presentation
{
    partial class CourseManagementForm
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
			this.dgvCourses = new System.Windows.Forms.DataGridView();
			this.BtnAddCourse = new System.Windows.Forms.Button();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtCredits = new System.Windows.Forms.TextBox();
			this.chkIsCore = new System.Windows.Forms.CheckBox();
			this.btnUpdateCourse = new System.Windows.Forms.Button();
			this.btnDeleteCourse = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvCourses
			// 
			this.dgvCourses.AllowUserToAddRows = false;
			this.dgvCourses.AllowUserToDeleteRows = false;
			this.dgvCourses.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCourses.Location = new System.Drawing.Point(18, 180);
			this.dgvCourses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.dgvCourses.Name = "dgvCourses";
			this.dgvCourses.ReadOnly = true;
			this.dgvCourses.RowHeadersWidth = 51;
			this.dgvCourses.RowTemplate.Height = 24;
			this.dgvCourses.Size = new System.Drawing.Size(1022, 505);
			this.dgvCourses.TabIndex = 0;
			this.dgvCourses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCourses_CellClick);
			// 
			// BtnAddCourse
			// 
			this.BtnAddCourse.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.BtnAddCourse.Location = new System.Drawing.Point(534, 47);
			this.BtnAddCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.BtnAddCourse.Name = "BtnAddCourse";
			this.BtnAddCourse.Size = new System.Drawing.Size(188, 61);
			this.BtnAddCourse.TabIndex = 1;
			this.BtnAddCourse.Text = "Add Course";
			this.BtnAddCourse.UseVisualStyleBackColor = false;
			this.BtnAddCourse.Click += new System.EventHandler(this.btnAddCourse_Click);
			// 
			// txtCode
			// 
			this.txtCode.Location = new System.Drawing.Point(238, 36);
			this.txtCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(148, 31);
			this.txtCode.TabIndex = 2;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(238, 118);
			this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(148, 31);
			this.txtTitle.TabIndex = 3;
			// 
			// txtCredits
			// 
			this.txtCredits.Location = new System.Drawing.Point(238, 77);
			this.txtCredits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtCredits.Name = "txtCredits";
			this.txtCredits.Size = new System.Drawing.Size(148, 31);
			this.txtCredits.TabIndex = 4;
			// 
			// chkIsCore
			// 
			this.chkIsCore.AutoSize = true;
			this.chkIsCore.Location = new System.Drawing.Point(404, 79);
			this.chkIsCore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.chkIsCore.Name = "chkIsCore";
			this.chkIsCore.Size = new System.Drawing.Size(112, 29);
			this.chkIsCore.TabIndex = 6;
			this.chkIsCore.Text = "Is Core";
			this.chkIsCore.UseVisualStyleBackColor = true;
			// 
			// btnUpdateCourse
			// 
			this.btnUpdateCourse.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnUpdateCourse.Location = new System.Drawing.Point(751, 47);
			this.btnUpdateCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnUpdateCourse.Name = "btnUpdateCourse";
			this.btnUpdateCourse.Size = new System.Drawing.Size(188, 61);
			this.btnUpdateCourse.TabIndex = 7;
			this.btnUpdateCourse.Text = "Update Course";
			this.btnUpdateCourse.UseVisualStyleBackColor = false;
			this.btnUpdateCourse.Click += new System.EventHandler(this.btnUpdateCourse_Click);
			// 
			// btnDeleteCourse
			// 
			this.btnDeleteCourse.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnDeleteCourse.Location = new System.Drawing.Point(969, 47);
			this.btnDeleteCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDeleteCourse.Name = "btnDeleteCourse";
			this.btnDeleteCourse.Size = new System.Drawing.Size(188, 61);
			this.btnDeleteCourse.TabIndex = 8;
			this.btnDeleteCourse.Text = "Delete Course";
			this.btnDeleteCourse.UseVisualStyleBackColor = false;
			this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(144, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 25);
			this.label1.TabIndex = 9;
			this.label1.Text = "Code:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(144, 121);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 25);
			this.label2.TabIndex = 10;
			this.label2.Text = "Title:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(144, 83);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 25);
			this.label3.TabIndex = 11;
			this.label3.Text = "Credits:";
			// 
			// btnBack
			// 
			this.btnBack.Location = new System.Drawing.Point(22, 20);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(107, 38);
			this.btnBack.TabIndex = 12;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// CourseManagementForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 703);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDeleteCourse);
			this.Controls.Add(this.btnUpdateCourse);
			this.Controls.Add(this.chkIsCore);
			this.Controls.Add(this.txtCredits);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.txtCode);
			this.Controls.Add(this.BtnAddCourse);
			this.Controls.Add(this.dgvCourses);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CourseManagementForm";
			this.Text = "CourseManagementForm";
			this.Load += new System.EventHandler(this.CourseManagementForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button BtnAddCourse;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.CheckBox chkIsCore;
        private System.Windows.Forms.Button btnUpdateCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
    }
}