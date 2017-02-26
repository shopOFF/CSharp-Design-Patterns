using System;

namespace RepositoryAndUnitOfWork.Contracts
{
   public interface IUnitOfWork :IDisposable
    {
        ICategoryRepository Categories { get; }

        IProductRepository Products { get; }

        int SaveChanges();
    }
}
