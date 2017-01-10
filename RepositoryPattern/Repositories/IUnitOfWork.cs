using System;
using RepositoryPattern.Data;

namespace RepositoryPattern.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICourseRepository Courses { get; }
        IAuthorRepository Authors { get; }
        int Complete();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly PlutoContext _context;

        public UnitOfWork(PlutoContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);
            Authors = new AuthorRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public ICourseRepository Courses { get; }
        public IAuthorRepository Authors { get; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}