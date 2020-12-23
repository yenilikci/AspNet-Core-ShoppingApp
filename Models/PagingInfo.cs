using ShoppingApp.WebUI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; } //kaç tane ürün var
        public int ItemsPerPage { get; set; } //kaç tanesi o an sayfaya gelecek
        public int CurrentPage { get; set; } //o an ki sayfa
        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }

    }

    public class ProductListModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
