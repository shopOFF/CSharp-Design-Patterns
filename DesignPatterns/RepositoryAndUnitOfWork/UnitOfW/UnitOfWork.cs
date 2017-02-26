using RepositoryAndUnitOfWork.Contracts;
using RepositoryAndUnitOfWork.DatabContext;
using RepositoryAndUnitOfWork.Repositories;

namespace RepositoryAndUnitOfWork.UnitOfW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext db;
        private ICategoryRepository categories;
        private IProductRepository products;

        public UnitOfWork()
        {
            db = new DatabaseContext();
        }

        public ICategoryRepository Categories
        {
            get
            {
                if (this.categories == null)
                {
                    this.categories = new CategoryRepository(db);
                }
                return this.categories;
            }
        }

        public IProductRepository Products
        {
            get
            {
                if (this.products == null)
                {
                    this.products = new ProductRepository(db);
                }
                return this.products;
            }
        }

        public int SaveChanges()
        {
            return db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
