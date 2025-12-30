using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCAIS.Presentation
{
    public partial class AdviserDashboardForm : Form
    {
        public AdviserDashboardForm()
        {
            InitializeComponent();
        }

        private void AdviserDashboardForm_Load(object sender, EventArgs e)
        {
            cmbStatusFilter.Items.Clear();
            cmbStatusFilter.Items.Add("All");
            cmbStatusFilter.Items.Add("Pending");
            cmbStatusFilter.Items.Add("Approved");
            cmbStatusFilter.Items.Add("Rejected");
            cmbStatusFilter.SelectedIndex = 0;

            lstPlans.Items.Add("Plan 101 - Student: Ali - Pending");
            lstPlans.Items.Add("Plan 102 - Student: Sara - Pending");
            lstPlans.Items.Add("Plan 103 - Student: Omar - Approved");
            if (cmbStatusFilter.Items.Count == 0)
            {
                cmbStatusFilter.Items.Add("All");
                cmbStatusFilter.Items.Add("Pending");
                cmbStatusFilter.Items.Add("Approved");
                cmbStatusFilter.Items.Add("Rejected");
            }

            cmbStatusFilter.SelectedIndex = 0; // All

            LoadPlansByStatus();
        }
        private void lstPlans_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lstPlanCourses.Items.Clear();

            if (lstPlans.SelectedItem == null)
                return;

            // For demo: show different courses depending on which plan is selected
            if (lstPlans.SelectedIndex == 0) // first plan
            {
                lstPlanCourses.Items.Add("PROG101 - Programming 1");
                lstPlanCourses.Items.Add("DB101   - Database 1");
                lstPlanCourses.Items.Add("WEB101  - Web Development 1");
            }
            else if (lstPlans.SelectedIndex == 1) // second plan
            {
                lstPlanCourses.Items.Add("NET101  - Computer Networks 1");
                lstPlanCourses.Items.Add("NET201  - Computer Networks 2");
                lstPlanCourses.Items.Add("SEC101  - Introduction to Cybersecurity");
            }
            else
            {
                lstPlanCourses.Items.Add("PROG201 - Object Oriented Programming");
                lstPlanCourses.Items.Add("DB201   - Database 2");
            }
        }
        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (!ValidateBeforeApprove())
                return;    // show errors, do nothing

            string plan = lstPlans.SelectedItem.ToString();
            string remarks = txtRemarks.Text;

            string message =
                "Approved plan:\n" + plan +
                "\n\nCourses:\n";

            foreach (var item in lstPlanCourses.Items)
            {
                message += "- " + item.ToString() + "\n";
            }

            message += "\nRemarks:\n" +
                (string.IsNullOrWhiteSpace(remarks) ? "(none)" : remarks);

            MessageBox.Show(message, "Plan Approved");
        }
        private void btnReject_Click(object sender, EventArgs e)
        {
            if (!ValidateBeforeReject())
                return;    // show errors, do nothing

            string plan = lstPlans.SelectedItem.ToString();
            string remarks = txtRemarks.Text;

            string message =
                "Rejected plan:\n" + plan +
                "\n\nRemarks:\n" + remarks;

            MessageBox.Show(message, "Plan Rejected");
        }
        private bool ValidateBeforeApprove()
        {
            errorProvider1.Clear();
            bool ok = true;

            // Must have a plan selected
            if (lstPlans.SelectedItem == null)
            {
                errorProvider1.SetError(lstPlans, "Please select a plan first.");
                ok = false;
            }

            return ok;
        }
        private bool ValidateBeforeReject()
        {
            errorProvider1.Clear();
            bool ok = true;

            // Must have a plan selected
            if (lstPlans.SelectedItem == null)
            {
                errorProvider1.SetError(lstPlans, "Please select a plan first.");
                ok = false;
            }

            // Remarks required when rejecting
            if (string.IsNullOrWhiteSpace(txtRemarks.Text))
            {
                errorProvider1.SetError(txtRemarks, "Please enter a reason for rejection.");
                ok = false;
            }

            return ok;
        }
        private void LoadPlansByStatus()
        {
            lstPlans.Items.Clear();
            lstPlanCourses.Items.Clear();
            txtRemarks.Clear();

            string selectedStatus = cmbStatusFilter.SelectedItem?.ToString() ?? "All";

            // Demo data with explicit statuses
            AddPlan("Plan 101 - Student: Ali   - Pending", "Pending", selectedStatus);
            AddPlan("Plan 102 - Student: Sara  - Pending", "Pending", selectedStatus);
            AddPlan("Plan 103 - Student: Omar  - Approved", "Approved", selectedStatus);
            // You can add Rejected examples if you like:
            // AddPlan("Plan 104 - Student: Mary - Rejected", "Rejected", selectedStatus);
        }
        private void AddPlan(string planText, string planStatus, string selectedStatus)
        {
            if (selectedStatus == "All" || selectedStatus == planStatus)
            {
                lstPlans.Items.Add(planText);
            }
        }
        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlansByStatus();
        }

    }
}
