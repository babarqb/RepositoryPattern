using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using RepositoryPattern.Data;
using RepositoryPattern.Model;

namespace RepositoryPattern.Repositories
{
    public class CourseRepository : Repository<Course>, ICourseRepository
    {
        public PlutoContext PlutoContext => Context as PlutoContext;

        public CourseRepository(PlutoContext context) : base(context)
        {

        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return PlutoContext.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pagesize)
        {
            return PlutoContext.Courses
                       .Include(c => c.Author)
                       .OrderBy(c => c.Name)
                       .Skip((pageIndex - 1) * pagesize)
                       .Take(pagesize)
                       .ToList();
        }
    }
}