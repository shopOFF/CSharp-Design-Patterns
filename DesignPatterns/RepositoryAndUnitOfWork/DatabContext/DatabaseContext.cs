using RepositoryAndUnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryAndUnitOfWork.DatabContext
{
     public class DatabaseContext :DbContext
    {
        public DatabaseContext()
           : base("DefaultConnection")
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.ProductId).ToTable("Product");

            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired().IsUnicode(false).HasMaxLength(50);
            modelBuilder.Entity<Product>().Property(p => p.Description).IsRequired().HasColumnType("varchar").HasMaxLength(500);

            //1:m
            modelBuilder.Entity<Product>().HasRequired(p => p.Category).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId);

            //modelBuilder.Entity<Category>().HasKey(p => p.CategoryId).ToTable("Category");
            //modelBuilder.Entity<Category>().Property(c => c.Name).IsUnicode(false).HasMaxLength(100).IsRequired();
        }

        public Product usp_getProduct(int id)
        {
            return this.Database.SqlQuery<Product>("Exec usp_getProduct @ProductId", new SqlParameter("ProductId", id)).FirstOrDefault();
        }

        public Product fn_getProduct(int id)
        {
            return this.Database.SqlQuery<Product>("Select * from fn_getProduct (@ProductId)", new SqlParameter("ProductId", id)).FirstOrDefault();
        }
    }
}
