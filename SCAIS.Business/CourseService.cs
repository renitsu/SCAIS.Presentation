using System.Data;
using SCAIS.Data;

namespace SCAIS.Business
{
	public class CourseService   // MUST be public
	{
		private readonly CourseRepository repo;

		public CourseService()
		{
			repo = new CourseRepository();
		}

		public DataTable GetAll()
		{
			return repo.GetAllCourses();
		}

		public void AddCourse(string code, string title, int credits, bool isCore)
		{
			repo.AddCourse(code, title, credits, isCore);
		}

		public void UpdateCourse(int courseId, string code, string title, int credits, bool isCore)
		{
			repo.UpdateCourse(courseId, title, code, credits, isCore);
		}

		public void DeleteCourse(int courseId)
		{
			repo.DeleteCourse(courseId);
		}
	}
}
