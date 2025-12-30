using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SCAIS.Data;  
namespace SCAIS.Presentation
{
	public partial class LoginForm : System.Windows.Forms.Form
	{
		public LoginForm()
		{
			InitializeComponent();

			lblMessage.Visible = false;
			lblMessage.Text = "";

			btnLogin.Click -= btnLogin_Click;
			btnLogin.Click += btnLogin_Click;

			btnExit.Click -= btnExit_Click;
			btnExit.Click += btnExit_Click;
		}



		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text.Trim();
			string password = txtPassword.Text.Trim();

			lblMessage.Visible = false;
			lblMessage.Text = "";

			if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
			{
				lblMessage.Text = "Please enter both username and password.";
				lblMessage.ForeColor = System.Drawing.Color.Red;
				lblMessage.Visible = true;
				return;
			}

			UserRepository repo = new UserRepository();
			DataRow userRow = repo.CheckLogin(username, password);

			if (userRow == null)
			{
				lblMessage.Text = "Invalid username or password.";
				lblMessage.ForeColor = System.Drawing.Color.Red;
				lblMessage.Visible = true;
				return;
			}

			string role = userRow["Role"].ToString().Trim();

			if (role.Equals("ADMIN", StringComparison.OrdinalIgnoreCase))
			{
				this.Hide();
				AdminDashboard dashboard = new AdminDashboard();
				dashboard.Show();
			}
			else if (role.Equals("STUDENT", StringComparison.OrdinalIgnoreCase))
			{
				this.Hide();
				StudentDashboard dashboard = new StudentDashboard();
				dashboard.Show();
			}


			else
			{
				lblMessage.Text = "Access denied. Admins only.";
				lblMessage.ForeColor = System.Drawing.Color.OrangeRed;
				lblMessage.Visible = true;
			}
			}
		


		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Designer-created handlers – keep them empty
		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void lblUsername_Click(object sender, EventArgs e)
		{
		}

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
