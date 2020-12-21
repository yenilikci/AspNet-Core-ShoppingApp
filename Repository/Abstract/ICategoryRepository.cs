using ShoppingApp.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Repository.Abstract
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetByName(string name);
    }
}
