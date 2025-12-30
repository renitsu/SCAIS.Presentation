using System.Data;
using System.Data.SqlClient;

namespace SCAIS.Data
{
	public static class DbHelper
	{
		private static readonly string _connStr =
			@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SCAIS_DB;Integrated Security=True;TrustServerCertificate=True;";


		public static SqlConnection GetConnection()
		{
			return new SqlConnection(_connStr);
		}

		public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameters)
		{
			DataTable table = new DataTable();

			using (SqlConnection conn = GetConnection())
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				if (parameters != null && parameters.Length > 0)
					cmd.Parameters.AddRange(parameters);

				using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
				{
					adapter.Fill(table);
				}
			}

			return table;
		}

		// ✅ Runs INSERT/UPDATE/DELETE and returns rows affected
		public static int ExecuteNonQuery(string sql, params SqlParameter[] parameters)
		{
			using (SqlConnection conn = GetConnection())
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				if (parameters != null && parameters.Length > 0)
					cmd.Parameters.AddRange(parameters);

				conn.Open();
				return cmd.ExecuteNonQuery();
			}
		}

		// ✅ Returns single value (COUNT(*), etc.)
		public static object ExecuteScalar(string sql, params SqlParameter[] parameters)
		{
			using (SqlConnection conn = GetConnection())
			using (SqlCommand cmd = new SqlCommand(sql, conn))
			{
				if (parameters != null && parameters.Length > 0)
					cmd.Parameters.AddRange(parameters);

				conn.Open();
				return cmd.ExecuteScalar();
			}
		}
	}
}
