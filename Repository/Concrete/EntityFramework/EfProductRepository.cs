using ShoppingApp.WebUI.Entity;
using ShoppingApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : IProductRepository
    {
        private ShoppingContext context;

        public EfProductRepository(ShoppingContext _context)
        {
            context = _context;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
