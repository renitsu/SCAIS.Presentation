using System;
using System.ComponentModel;
using System.Windows.Forms;
using SCAIS.Business;
using SCAIS.Data;
namespace SCAIS.Presentation
{
	public partial class CourseManagementForm : Form
	{
	private CourseService service; // <-- FIX: don't new here
		private int selectedCourseId = -1;

		public CourseManagementForm()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		private void CourseManagementForm_Load(object sender, EventArgs e)
		{
			
			// FIX: stop Designer from crashing
			if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
				return;

			// create service only when running
			service = new CourseService();

			// hook grid click safely (controls exist now)
			dgvCourses.CellClick -= dgvCourses_CellClick;
			dgvCourses.CellClick += dgvCourses_CellClick;

			LoadCourses();
			
		}

		private void LoadCourses()
		{
			dgvCourses.DataSource = service.GetAll();
			dgvCourses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0) return;

			DataGridViewRow row = dgvCourses.Rows[e.RowIndex];

			selectedCourseId = Convert.ToInt32(row.Cells["CourseId"].Value);
			txtCode.Text = row.Cells["Code"].Value?.ToString();
			txtTitle.Text = row.Cells["Title"].Value?.ToString();
			txtCredits.Text = row.Cells["Credits"].Value?.ToString();

			object v = row.Cells["IsCore"].Value;
			if (v != null && v != DBNull.Value)
				chkIsCore.Checked = Convert.ToBoolean(v);
			else
				chkIsCore.Checked = false;
		}

		private void btnAddCourse_Click(object sender, EventArgs e)
		{
			string code = txtCode.Text.Trim();
			string title = txtTitle.Text.Trim();

			if (!int.TryParse(txtCredits.Text.Trim(), out int credits))
			{
				MessageBox.Show("Credits must be a number.");
				return;
			}

			bool isCore = chkIsCore.Checked;

			if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(title))
			{
				MessageBox.Show("Code and Title are required.");
				return;
			}

			service.AddCourse(code, title, credits, isCore);

			MessageBox.Show("Course added successfully.");

			LoadCourses();

			txtCode.Clear();
			txtTitle.Clear();
			txtCredits.Clear();
			chkIsCore.Checked = false;
			selectedCourseId = -1;
		}

		private void btnUpdateCourse_Click(object sender, EventArgs e)
		{
			if (selectedCourseId <= 0)
			{
				MessageBox.Show("Select a course from the list first.");
				return;
			}

			string code = txtCode.Text.Trim();
			string title = txtTitle.Text.Trim();

			if (!int.TryParse(txtCredits.Text.Trim(), out int credits))
			{
				MessageBox.Show("Credits must be a number.");
				return;
			}

			bool isCore = chkIsCore.Checked;

			if (string.IsNullOrWhiteSpace(code) || string.IsNullOrWhiteSpace(title))
			{
				MessageBox.Show("Code and Title are required.");
				return;
			}

			service.UpdateCourse(selectedCourseId, code, title, credits, isCore);

			MessageBox.Show("Course updated successfully.");
			LoadCourses();
		}

		private void btnDeleteCourse_Click(object sender, EventArgs e)
		{
			if (selectedCourseId <= 0)
			{
				MessageBox.Show("Select a course from the list first.");
				return;
			}

			var confirm = MessageBox.Show(
				"Are you sure you want to delete this course?",
				"Confirm Delete",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Warning);

			if (confirm != DialogResult.Yes)
				return;

			service.DeleteCourse(selectedCourseId);

			MessageBox.Show("Course deleted successfully.");
			LoadCourses();

			selectedCourseId = -1;
			txtCode.Clear();
			txtTitle.Clear();
			txtCredits.Clear();
			chkIsCore.Checked = false;
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

        private void btnBack_Click(object sender, EventArgs e)
        {
			this.Close();
		}
	}
}
