using RepositoryAndUnitOfWork.Models;
using System.Collections.Generic;

namespace RepositoryAndUnitOfWork.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetProductsByCategory(int id);
    }
}
