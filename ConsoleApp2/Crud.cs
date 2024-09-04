using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Crud : ICrud
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var existingProduct = FindProductById(product.Id);
            if (existingProduct != null)
            {
                products.Remove(existingProduct);
                products.Add(product);
            }
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product FindProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void DeleteProduct(int id)
        {
            var product = FindProductById(id);
            if (product != null)
            {
                products.Remove(product);
            }
        }
    }
}
