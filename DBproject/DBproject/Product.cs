using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject
{
    public class Product
    {
        public int Quantity;
        public int stockQuantity;
        public int Price;
        public string Name;
        public string Category;
        public Product(string Name, string Category, int Quantity, int stockQuantity, int Price)
        {
            this.Quantity = Quantity;
            this.stockQuantity = stockQuantity;
            this.Price = Price;
            this.Name = Name;
            this.Category = Category;
        }
    }
}
