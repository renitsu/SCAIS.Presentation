namespace SCAIS.Presentation
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnManageStudentPlans = new System.Windows.Forms.Button();
            this.btnManagePrereqs = new System.Windows.Forms.Button();
            this.btnManageCourses = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnExitAdmin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdministratorDashboard = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(147, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(239, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Administrator Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelMenu.Controls.Add(this.btnManageStudentPlans);
            this.panelMenu.Controls.Add(this.btnManagePrereqs);
            this.panelMenu.Controls.Add(this.btnManageCourses);
            this.panelMenu.Controls.Add(this.btnManageUsers);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(124, 355);
            this.panelMenu.TabIndex = 1;
            // 
            // btnManageStudentPlans
            // 
            this.btnManageStudentPlans.Location = new System.Drawing.Point(12, 187);
            this.btnManageStudentPlans.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageStudentPlans.Name = "btnManageStudentPlans";
            this.btnManageStudentPlans.Size = new System.Drawing.Size(101, 41);
            this.btnManageStudentPlans.TabIndex = 3;
            this.btnManageStudentPlans.Text = "Manage Student Plans";
            this.btnManageStudentPlans.UseVisualStyleBackColor = true;
            this.btnManageStudentPlans.Click += new System.EventHandler(this.btnManageStudentPlans_Click);
            // 
            // btnManagePrereqs
            // 
            this.btnManagePrereqs.Location = new System.Drawing.Point(12, 130);
            this.btnManagePrereqs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManagePrereqs.Name = "btnManagePrereqs";
            this.btnManagePrereqs.Size = new System.Drawing.Size(101, 33);
            this.btnManagePrereqs.TabIndex = 2;
            this.btnManagePrereqs.Text = "Prerequisite Rules";
            this.btnManagePrereqs.UseVisualStyleBackColor = true;
            // 
            // btnManageCourses
            // 
            this.btnManageCourses.Location = new System.Drawing.Point(12, 70);
            this.btnManageCourses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageCourses.Name = "btnManageCourses";
            this.btnManageCourses.Size = new System.Drawing.Size(101, 33);
            this.btnManageCourses.TabIndex = 1;
            this.btnManageCourses.Text = "Manage Courses";
            this.btnManageCourses.UseVisualStyleBackColor = true;
            this.btnManageCourses.Click += new System.EventHandler(this.btnManageCourses_Click);
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.Location = new System.Drawing.Point(12, 15);
            this.btnManageUsers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(101, 33);
            this.btnManageUsers.TabIndex = 0;
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnExitAdmin);
            this.panelMain.Controls.Add(this.btnLogout);
            this.panelMain.Controls.Add(this.pictureBox1);
            this.panelMain.Controls.Add(this.lblAdministratorDashboard);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(124, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(410, 355);
            this.panelMain.TabIndex = 2;
            // 
            // btnExitAdmin
            // 
            this.btnExitAdmin.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnExitAdmin.Location = new System.Drawing.Point(330, 314);
            this.btnExitAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExitAdmin.Name = "btnExitAdmin";
            this.btnExitAdmin.Size = new System.Drawing.Size(74, 29);
            this.btnExitAdmin.TabIndex = 3;
            this.btnExitAdmin.Text = "Exit";
            this.btnExitAdmin.UseVisualStyleBackColor = false;
            this.btnExitAdmin.Click += new System.EventHandler(this.btnExitAdmin_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLogout.Location = new System.Drawing.Point(242, 314);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(74, 29);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(320, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblAdministratorDashboard
            // 
            this.lblAdministratorDashboard.AutoSize = true;
            this.lblAdministratorDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministratorDashboard.Location = new System.Drawing.Point(49, 17);
            this.lblAdministratorDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAdministratorDashboard.Name = "lblAdministratorDashboard";
            this.lblAdministratorDashboard.Size = new System.Drawing.Size(239, 24);
            this.lblAdministratorDashboard.TabIndex = 0;
            this.lblAdministratorDashboard.Text = "Administrator Dashboard";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 355);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCAIS - AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminDashboard_FormClosed_1);
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnManageStudentPlans;
        private System.Windows.Forms.Button btnManagePrereqs;
        private System.Windows.Forms.Button btnManageCourses;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblAdministratorDashboard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExitAdmin;
        private System.Windows.Forms.Button btnLogout;
    }
}