using System.Data.Entity;
using RepositoryPattern.Model;

namespace RepositoryPattern.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(DbContext context) : base(context)
        {
        }

        public Author GetAuthorWithcourses(int i)
        {
            throw new System.NotImplementedException();
        }
    }
}