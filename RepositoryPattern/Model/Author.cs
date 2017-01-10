using System.Collections.Generic;

namespace RepositoryPattern.Model
{
    public class Author
    {
        public Author()
        {
            Courses = new HashSet<Course>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}