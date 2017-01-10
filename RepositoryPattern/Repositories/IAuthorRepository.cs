using RepositoryPattern.Model;

namespace RepositoryPattern.Repositories
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Author GetAuthorWithcourses(int i);
    }
}