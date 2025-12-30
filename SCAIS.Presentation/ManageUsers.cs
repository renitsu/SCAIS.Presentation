using System;
using System.ComponentModel;   // for LicenseManager
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SCAIS.Data;


namespace SCAIS.Presentation
{
	public partial class ManageUsers : Form
	{
		private UserRepository _userRepository;

		public ManageUsers()
		{
			InitializeComponent();

			// Designer-safe: don't run DB stuff while designer is loading
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
				return;

			_userRepository = new UserRepository();
		}

		private void ManageUsers_Load(object sender, EventArgs e)
		{
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
				return;

			LoadRoles();
			LoadUsersGrid();
			ClearInputs();
		}

		private void LoadRoles()
		{
			cmbRole.Items.Clear();
			cmbRole.Items.Add("ADMIN");
			cmbRole.Items.Add("STUDENT");
			cmbRole.Items.Add("ADVISER");
			cmbRole.SelectedIndex = -1;
		}

		private void LoadUsersGrid()
		{
			if (_userRepository == null)
				return;

			try
			{
				DataTable usersTable = _userRepository.GetAllUsers();
				dgvUsers.DataSource = usersTable;

				// Hide password column if it exists
				if (dgvUsers.Columns.Contains("PasswordHash"))
					dgvUsers.Columns["PasswordHash"].Visible = false;

				dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
				dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
				dgvUsers.MultiSelect = false;
				dgvUsers.ReadOnly = true;
				dgvUsers.ClearSelection();
			}
			catch (Exception ex)
			{
				MessageBox.Show("DB Error: " + ex.Message);
			}
		}

		private void ClearInputs()
		{
			txtUserId.Text = "";
			txtUsername.Text = "";
			txtFullName.Text = "";
			txtEmail.Text = "";
			cmbRole.SelectedIndex = -1;

			// reset email highlight
			txtEmail.BackColor = Color.White;
		}

		private bool IsValidEmail(string email)
		{
			// simple but OK for uni project
			return email.Contains("@") && email.Contains(".");
		}

		private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			DataGridViewRow row = dgvUsers.Rows[e.RowIndex];

			txtUserId.Text = row.Cells["UserId"].Value.ToString();
			txtUsername.Text = row.Cells["Username"].Value.ToString();
			txtFullName.Text = row.Cells["FullName"].Value.ToString();
			txtEmail.Text = row.Cells["Email"].Value == DBNull.Value ? "" : row.Cells["Email"].Value.ToString();
			cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
		}

		// If your designer is wired to CellContentClick instead of CellClick, keep this.
		// Otherwise you can delete this method and also remove it from Properties -> Events.
		private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvUsers_CellClick(sender, e);
		}

		private void btnAddUser_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text.Trim();
			string fullName = txtFullName.Text.Trim();
			string email = txtEmail.Text.Trim();
			string role = cmbRole.SelectedItem == null ? "" : cmbRole.SelectedItem.ToString();

			// required fields
			if (string.IsNullOrEmpty(username) ||
				string.IsNullOrEmpty(fullName) ||
				string.IsNullOrEmpty(role))
			{
				MessageBox.Show(
					"Please fill Username, Full Name and Role.",
					"Add User",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			// email optional, but if typed must be valid
			if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
			{
				MessageBox.Show(
					"Please enter a valid email address.",
					"Invalid Email",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				txtEmail.Focus();
				return;
			}

			string tempPassword = "Temp@123";

			bool ok = _userRepository.AddUser(username, tempPassword, fullName, email, role);

			if (ok)
			{
				MessageBox.Show(
					"User added successfully. Temporary password is: Temp@123",
					"Add User",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

				LoadUsersGrid();
				ClearInputs();
			}
			else
			{
				// AddUser already shows duplicate username message if needed
				MessageBox.Show(
					"Failed to add user.",
					"Add User",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void btnUpdateUser_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtUserId.Text, out int userId) || userId <= 0)
			{
				MessageBox.Show(
					"Please select a user from the list.",
					"Update User",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			string username = txtUsername.Text.Trim();
			string fullName = txtFullName.Text.Trim();
			string email = txtEmail.Text.Trim();
			string role = cmbRole.SelectedItem == null ? "" : cmbRole.SelectedItem.ToString();

			if (string.IsNullOrEmpty(username) ||
				string.IsNullOrEmpty(fullName) ||
				string.IsNullOrEmpty(role))
			{
				MessageBox.Show(
					"Please fill Username, Full Name and Role.",
					"Update User",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			if (!string.IsNullOrEmpty(email) && !IsValidEmail(email))
			{
				MessageBox.Show(
					"Please enter a valid email address.",
					"Invalid Email",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				txtEmail.Focus();
				return;
			}

			bool ok = _userRepository.UpdateUserNoPassword(userId, username, fullName, email, role);

			if (ok)
			{
				MessageBox.Show(
					"User updated successfully.",
					"Update User",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

				LoadUsersGrid();
				ClearInputs();
			}
			else
			{
				MessageBox.Show(
					"Failed to update user.",
					"Update User",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void btnDeleteUser_Click(object sender, EventArgs e)
		{
			if (!int.TryParse(txtUserId.Text, out int userId) || userId <= 0)
			{
				MessageBox.Show(
					"Please select a user to delete.",
					"Delete User",
					MessageBoxButtons.OK,
					MessageBoxIcon.Warning);
				return;
			}

			DialogResult dr = MessageBox.Show(
				"Are you sure you want to delete this user?",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (dr != DialogResult.Yes)
				return;

			bool ok = _userRepository.DeleteUser(userId);

			if (ok)
			{
				MessageBox.Show(
					"User deleted successfully.",
					"Delete User",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information);

				LoadUsersGrid();
				ClearInputs();
			}
			else
			{
				MessageBox.Show(
					"Failed to delete user.",
					"Delete User",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
			}
		}

		private void btnClearUser_Click(object sender, EventArgs e)
		{
			ClearInputs();
		}

		private void btnBack_Click(object sender, EventArgs e)
		{
			this.Hide();
			AdminDashboard dashboard = new AdminDashboard();
			dashboard.Show();
		}

		private void txtEmail_TextChanged(object sender, EventArgs e)
		{
			string email = txtEmail.Text.Trim();

			if (string.IsNullOrEmpty(email))
			{
				txtEmail.BackColor = Color.White;
				return;
			}

			txtEmail.BackColor = IsValidEmail(email) ? Color.White : Color.MistyRose;
		}
	}
}
