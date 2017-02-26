using RepositoryAndUnitOfWork.Contracts;
using RepositoryAndUnitOfWork.DatabContext;
using RepositoryAndUnitOfWork.Models;
using System.Data.Entity;

namespace RepositoryAndUnitOfWork.Repositories
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext database) 
            : base(database)
        {
        }

        public DatabaseContext context
        {
            get
            {
                return db as DatabaseContext;
            }
        }
    }
}
