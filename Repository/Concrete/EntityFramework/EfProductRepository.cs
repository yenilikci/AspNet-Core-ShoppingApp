using ShoppingApp.WebUI.Entity;
using ShoppingApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : EfGenericRepository<Product>, IProductRepository
    {

        public EfProductRepository(ShoppingContext context) : base(context)
        {
                
        }

        public ShoppingContext ShoppingContext
        {
            get
            {
                return context as ShoppingContext;
            }//context'i ShoppingContext olarak aldı
        }


        public List<Product> Get5TopProducts()
        {
            return ShoppingContext.Products //azalan şekilde sıralı ve 5 tanesini al
                .OrderByDescending(i => i.ProductId)
                .Take(5)
                .ToList();
        }
    }
}
