using System;
using System.Windows.Forms;
using SCAIS.Data;

namespace SCAIS.Presentation
{
	public partial class AdminDashboard : Form
	{
		public AdminDashboard()
		{
			InitializeComponent();
		}

		private void AdminDashboard_Load(object sender, EventArgs e)
		{
		}

		private void btnExitAdmin_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void AdminDashboard_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// Add this to fix the error (or remove from Designer.cs)
		private void AdminDashboard_FormClosed_1(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		// Add this to fix the error (or remove from Designer.cs)
		private void pictureBox1_Click(object sender, EventArgs e)
		{
			// Empty - or add click behavior
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.Hide();
			LoginForm login = new LoginForm();
			login.Show();
		}

		private void btnManageUsers_Click(object sender, EventArgs e)
		{
			ManageUsers frm = new ManageUsers();
			frm.ShowDialog();
		}

		private void btnManageCourses_Click(object sender, EventArgs e)
		{
			this.Hide();
			var frm = new SCAIS.Presentation.CourseManagementForm();
			frm.FormClosed += (s, args) => this.Show();
			frm.Show();
		}

        private void btnManageStudentPlans_Click(object sender, EventArgs e)
        {
            AdviserDashboardForm adviserForm = new AdviserDashboardForm();

            // When adviser form closes, show admin dashboard again
            adviserForm.FormClosed += (s, args) => this.Show();

            this.Hide();
            adviserForm.Show();
        }
    }
}