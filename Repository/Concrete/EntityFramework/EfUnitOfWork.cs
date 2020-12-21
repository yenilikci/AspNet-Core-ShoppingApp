using ShoppingApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly ShoppingContext dbContext;

        public EfUnitOfWork(ShoppingContext _dbContext)
        {
            dbContext = _dbContext ?? throw new ArgumentNullException("dbcontext can not be null");
        }

        private IProductRepository _products;
        private ICategoryRepository _categories;

        public IProductRepository Products
        {
            get
            {
                return _products ?? (_products = new EfProductRepository(dbContext));
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                return _categories ?? (_categories = new EfCategoryRepository(dbContext));
            }
        }

        public int SaveChanges()
        {
            try
            {
                return dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }

    }
}
