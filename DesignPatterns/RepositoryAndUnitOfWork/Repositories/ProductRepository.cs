using RepositoryAndUnitOfWork.Contracts;
using RepositoryAndUnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RepositoryAndUnitOfWork.DatabContext;

namespace RepositoryAndUnitOfWork.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext database)
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

        public IEnumerable<Product> GetProductsByCategory(int id)
        {
            return context.Products.Where(p => p.CategoryId == id).ToList();
        }
    }
}
