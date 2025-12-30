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
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            // Year options
            

            // Courses
            clbCourses.Items.Clear();
            clbCourses.Items.Add("PROG101 - Programming 1");
            clbCourses.Items.Add("PROG201 - Object Oriented Programming");
            clbCourses.Items.Add("NET101  - Computer Networks 1");
            clbCourses.Items.Add("NET201  - Computer Networks 2");
            clbCourses.Items.Add("DB101   - Database 1");
            clbCourses.Items.Add("DB201   - Database 2");
            clbCourses.Items.Add("WEB101  - Web Development 1");
            clbCourses.Items.Add("WEB201  - Web Development 2");
            clbCourses.Items.Add("SEC101  - Introduction to Cybersecurity");
            clbCourses.Items.Add("OS101   - Operating Systems");

            lblSelectedCount.Text = "Selected: 0 / 4";
        }

        private void btnSubmitPlan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool hasError = false;

            // Validate Year
            if (string.IsNullOrWhiteSpace(cmbYear.Text))
            {
                errorProvider1.SetError(cmbYear, "Please select a Year.");
                hasError = true;
            }
            else if (!int.TryParse(cmbYear.Text, out int yearValue))
            {
                errorProvider1.SetError(cmbYear, "Year must be a number (e.g. 2025).");
                hasError = true;
            }

            // Validate Semester
            if (string.IsNullOrWhiteSpace(cmbSemester.Text))
            {
                errorProvider1.SetError(cmbSemester, "Please select a Semester.");
                hasError = true;
            }

            // Validate Courses
            if (clbCourses.CheckedItems.Count == 0)
            {
                errorProvider1.SetError(clbCourses, "Please select at least one course.");
                hasError = true;
            }
            else if (clbCourses.CheckedItems.Count > 4)
            {
                errorProvider1.SetError(clbCourses, "You can select a maximum of 4 courses.");
                hasError = true;
            }

            // If any errors, stop here
            if (hasError)
                return;

            string semester = cmbSemester.SelectedItem != null
                ? cmbSemester.SelectedItem.ToString()
                : "(no semester selected)";

            string summary = "You submitted a plan with these courses:\n";
            foreach (var item in clbCourses.CheckedItems)
            {
                summary += "- " + item.ToString() + "\n";
            }

            summary += $"\nTotal selected: {clbCourses.CheckedItems.Count} (max 4)";
            MessageBox.Show(summary, "Plan Submitted (Demo)");
        }
        private void clbCourses_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int current = clbCourses.CheckedItems.Count;

            // Predict new count after this click
            int newCount = current;
            if (e.NewValue == CheckState.Checked)
                newCount++;
            else if (e.NewValue == CheckState.Unchecked)
                newCount--;

            // Enforce max 4
            if (e.NewValue == CheckState.Checked && current >= 4)
            {
                MessageBox.Show("You can select a maximum of 4 courses.");
                e.NewValue = CheckState.Unchecked;
                newCount = current; // no change
            }

            // Update label text
            lblSelectedCount.Text = $"Selected: {newCount} / 4";
        }

        private void lblSelectedCount_Click(object sender, EventArgs e)
        {

        }
    }
}
