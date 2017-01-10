using System.Collections.Generic;
using RepositoryPattern.Model;

namespace RepositoryPattern.Repositories
{
    /// <summary>
    /// Coustom Course Repository Interface which also Implement IRepository<T>
    /// </summary>
    public interface ICourseRepository : IRepository<Course>
    {
        IEnumerable<Course> GetTopSellingCourses(int count);
        IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pagesize);
    }
}