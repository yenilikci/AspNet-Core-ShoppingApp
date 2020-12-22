using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingApp.WebUI.Entity
{
    public class ProductAttribute
    {
        public int ProductAttributeId { get; set; }
        public string Attribute { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; } //her bir özelliğin ait olduğu bir ürün olacak
        public Product Product { get; set; } //her bir ürüne geçiş yapabilmek için
    }
}
