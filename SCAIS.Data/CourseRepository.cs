using System.Data;
using System.Data.SqlClient;

namespace SCAIS.Data
{
    public class CourseRepository
    {
        public DataTable GetAllCourses()
        {
            string query = @"
                SELECT CourseId, Code, Title, Credits, IsCore
                FROM Courses
                ORDER BY Code;";

            return DbHelper.ExecuteDataTable(query, null);
        }

        public void AddCourse(string code, string title, int credits, bool isCore)
        {
            const string query = @"
                INSERT INTO Courses (Code, Title, Credits, IsCore)
                VALUES (@Code, @Title, @Credits, @IsCore);";

            SqlParameter[] parameters =
            {
                new SqlParameter("@Code", code),
                new SqlParameter("@Title", title),
                new SqlParameter("@Credits", credits),
                new SqlParameter("@IsCore", isCore)
            };

            DbHelper.ExecuteNonQuery(query, parameters);
        }

        public void UpdateCourse(int courseId, string code, string title, int credits, bool isCore)
        {
            const string query = @"
                UPDATE Courses
                SET Code = @Code,
                    Title = @Title,
                    Credits = @Credits,
                    IsCore = @IsCore
                WHERE CourseId = @CourseId;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@CourseId", courseId),
                new SqlParameter("@Code", code),
                new SqlParameter("@Title", title),
                new SqlParameter("@Credits", credits),
                new SqlParameter("@IsCore", isCore)
            };

            DbHelper.ExecuteNonQuery(query, parameters);
        }

        public void DeleteCourse(int courseId)
        {
            const string query = @"DELETE FROM Courses WHERE CourseId = @CourseId;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@CourseId", courseId)
            };

            DbHelper.ExecuteNonQuery(query, parameters);
        }
    }
}
