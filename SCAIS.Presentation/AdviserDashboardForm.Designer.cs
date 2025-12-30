namespace SCAIS.Presentation
{
    partial class AdviserDashboardForm
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
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnReject = new System.Windows.Forms.Button();
            this.txtRemarks = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lstPlanCourses = new System.Windows.Forms.ListBox();
            this.lblPlanCourses = new System.Windows.Forms.Label();
            this.lstPlans = new System.Windows.Forms.ListBox();
            this.lblPlans = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(462, 318);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(75, 23);
            this.btnApprove.TabIndex = 17;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(569, 318);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(75, 23);
            this.btnReject.TabIndex = 16;
            this.btnReject.Text = "Reject";
            this.btnReject.UseVisualStyleBackColor = true;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Location = new System.Drawing.Point(513, 213);
            this.txtRemarks.Multiline = true;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemarks.Size = new System.Drawing.Size(202, 65);
            this.txtRemarks.TabIndex = 15;
            // 
            // lblRemarks
            // 
            this.lblRemarks.AutoSize = true;
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.Location = new System.Drawing.Point(367, 213);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(130, 16);
            this.lblRemarks.TabIndex = 14;
            this.lblRemarks.Text = "Adviser Remarks:";
            // 
            // lstPlanCourses
            // 
            this.lstPlanCourses.FormattingEnabled = true;
            this.lstPlanCourses.Location = new System.Drawing.Point(528, 44);
            this.lstPlanCourses.Name = "lstPlanCourses";
            this.lstPlanCourses.Size = new System.Drawing.Size(230, 134);
            this.lstPlanCourses.TabIndex = 13;
            // 
            // lblPlanCourses
            // 
            this.lblPlanCourses.AutoSize = true;
            this.lblPlanCourses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanCourses.Location = new System.Drawing.Point(480, 13);
            this.lblPlanCourses.Name = "lblPlanCourses";
            this.lblPlanCourses.Size = new System.Drawing.Size(182, 16);
            this.lblPlanCourses.TabIndex = 12;
            this.lblPlanCourses.Text = "Courses in selected plan:";
            // 
            // lstPlans
            // 
            this.lstPlans.FormattingEnabled = true;
            this.lstPlans.Location = new System.Drawing.Point(258, 44);
            this.lstPlans.Name = "lstPlans";
            this.lstPlans.Size = new System.Drawing.Size(196, 134);
            this.lstPlans.TabIndex = 11;
            this.lstPlans.SelectedIndexChanged += new System.EventHandler(this.lstPlans_SelectedIndexChanged);
            // 
            // lblPlans
            // 
            this.lblPlans.AutoSize = true;
            this.lblPlans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlans.Location = new System.Drawing.Point(222, 13);
            this.lblPlans.Name = "lblPlans";
            this.lblPlans.Size = new System.Drawing.Size(106, 16);
            this.lblPlans.TabIndex = 10;
            this.lblPlans.Text = "Student Plans:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Approved",
            "Rejected"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(72, 9);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(121, 21);
            this.cmbStatusFilter.TabIndex = 19;
            this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 16);
            this.lblStatus.TabIndex = 18;
            this.lblStatus.Text = "Status:";
            // 
            // AdviserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.txtRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.lstPlanCourses);
            this.Controls.Add(this.lblPlanCourses);
            this.Controls.Add(this.lstPlans);
            this.Controls.Add(this.lblPlans);
            this.Controls.Add(this.cmbStatusFilter);
            this.Controls.Add(this.lblStatus);
            this.Name = "AdviserDashboardForm";
            this.Text = "AdviserDashboardForm";
            this.Load += new System.EventHandler(this.AdviserDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.TextBox txtRemarks;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.ListBox lstPlanCourses;
        private System.Windows.Forms.Label lblPlanCourses;
        private System.Windows.Forms.ListBox lstPlans;
        private System.Windows.Forms.Label lblPlans;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.Label lblStatus;
    }
}