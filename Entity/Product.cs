using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Entity
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string HtmlContent { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsApproved { get; set; }
        public bool IsHome { get; set; }
        public bool IsFeatured { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
        public List<Image> Images { get; set; } //Her bir ürünün Images'ine ulaştığımız zaman o ürünün bütün resimlerini bana getirir
        public List<ProductAttribute> Attributes { get; set; }
    }
}
