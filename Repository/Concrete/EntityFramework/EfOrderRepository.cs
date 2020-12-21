using ShoppingApp.WebUI.Entity;
using ShoppingApp.WebUI.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Repository.Concrete.EntityFramework
{
    public class EfOrderRepository : EfGenericRepository<Order>, IOrderRepository
    {
        public EfOrderRepository(ShoppingContext context) : base(context)
        {

        }
    }
}
