using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SCAIS.Data
{
	public class UserRepository
	{
		// ============================
		// READ: Load all users to grid
		// ============================
		public DataTable GetAllUsers()
		{
			DataTable table = new DataTable();

			using (SqlConnection conn = DbHelper.GetConnection())
			using (SqlCommand cmd = new SqlCommand(
				@"SELECT UserId,
						 Username,
						 FullName,
						 Email,
						 Role,
						 PasswordHash
				  FROM Users", conn))
			using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
			{
				conn.Open();
				adapter.Fill(table);
			}

			return table;
		}

		// ============================
		// CREATE: Add new user
		// ============================
		public bool AddUser(string username, string password, string fullName, string email, string role)
		{
			try
			{
				using (SqlConnection conn = DbHelper.GetConnection())
				using (SqlCommand cmd = new SqlCommand(
					@"INSERT INTO Users (Username, PasswordHash, FullName, Email, Role)
					  VALUES (@Username, @PasswordHash, @FullName, @Email, @Role)", conn))
				{
					cmd.Parameters.AddWithValue("@Username", username);
					cmd.Parameters.AddWithValue("@PasswordHash", password);
					cmd.Parameters.AddWithValue("@FullName", fullName);
					cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(email) ? (object)DBNull.Value : email);
					cmd.Parameters.AddWithValue("@Role", role);

					conn.Open();
					cmd.ExecuteNonQuery();
					return true;
				}
			}
			catch (SqlException ex)
			{
				if (ex.Number == 2627 || ex.Number == 2601)
				{
					MessageBox.Show(
						"Username already exists. Please choose another username.",
						"Duplicate Username",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show(
						"Database error: " + ex.Message,
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}

				return false;
			}
		}

		// ============================
		// UPDATE: Update user (WITH password)
		// ============================
		public bool UpdateUser(int userId, string username, string password, string fullName, string email, string role)
		{
			try
			{
				using (SqlConnection conn = DbHelper.GetConnection())
				using (SqlCommand cmd = new SqlCommand(
					@"UPDATE Users
					  SET Username = @Username,
						  PasswordHash = @PasswordHash,
						  FullName = @FullName,
						  Email = @Email,
						  Role = @Role
					  WHERE UserId = @UserId", conn))
				{
					cmd.Parameters.AddWithValue("@UserId", userId);
					cmd.Parameters.AddWithValue("@Username", username);
					cmd.Parameters.AddWithValue("@PasswordHash", password);
					cmd.Parameters.AddWithValue("@FullName", fullName);
					cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(email) ? (object)DBNull.Value : email);
					cmd.Parameters.AddWithValue("@Role", role);

					conn.Open();
					return cmd.ExecuteNonQuery() > 0;
				}
			}
			catch (SqlException ex)
			{
				if (ex.Number == 2627 || ex.Number == 2601)
				{
					MessageBox.Show(
						"Username already exists. Please choose another username.",
						"Duplicate Username",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show(
						"Database error: " + ex.Message,
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}

				return false;
			}
		}

		// ============================
		// UPDATE: Update user (NO password)
		// ============================
		public bool UpdateUserNoPassword(int userId, string username, string fullName, string email, string role)
		{
			try
			{
				using (SqlConnection conn = DbHelper.GetConnection())
				using (SqlCommand cmd = new SqlCommand(
					@"UPDATE Users
					  SET Username = @Username,
						  FullName = @FullName,
						  Email = @Email,
						  Role = @Role
					  WHERE UserId = @UserId", conn))
				{
					cmd.Parameters.AddWithValue("@UserId", userId);
					cmd.Parameters.AddWithValue("@Username", username);
					cmd.Parameters.AddWithValue("@FullName", fullName);
					cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(email) ? (object)DBNull.Value : email);
					cmd.Parameters.AddWithValue("@Role", role);

					conn.Open();
					return cmd.ExecuteNonQuery() > 0;
				}
			}
			catch (SqlException ex)
			{
				if (ex.Number == 2627 || ex.Number == 2601)
				{
					MessageBox.Show(
						"Username already exists. Please choose another username.",
						"Duplicate Username",
						MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
				}
				else
				{
					MessageBox.Show(
						"Database error: " + ex.Message,
						"Error",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}

				return false;
			}
		}

		// ============================
		// DELETE: Delete user
		// ============================
		public bool DeleteUser(int userId)
		{
			using (SqlConnection conn = DbHelper.GetConnection())
			using (SqlCommand cmd = new SqlCommand(
				"DELETE FROM Users WHERE UserId = @UserId", conn))
			{
				cmd.Parameters.AddWithValue("@UserId", userId);

				conn.Open();
				return cmd.ExecuteNonQuery() > 0;
			}
		}

		// ============================
		// LOGIN: Check username + password
		// ============================
		public DataRow CheckLogin(string username, string password)
		{
			DataTable table = new DataTable();

			using (SqlConnection conn = DbHelper.GetConnection())
			using (SqlCommand cmd = new SqlCommand(
				@"SELECT TOP 1 UserId,
							 Username,
							 FullName,
							 Email,
							 Role
				  FROM Users
				  WHERE Username = @Username
					AND PasswordHash = @PasswordHash", conn))
			using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
			{
				cmd.Parameters.AddWithValue("@Username", username);
				cmd.Parameters.AddWithValue("@PasswordHash", password);

				conn.Open();
				adapter.Fill(table);
			}

			if (table.Rows.Count == 0)
				return null;

			return table.Rows[0];
		}
	}
}
