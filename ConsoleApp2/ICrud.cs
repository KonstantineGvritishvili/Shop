using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface ICrud
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        List<Product> GetAllProducts();
        Product FindProductById(int id);
        void DeleteProduct(int id);
    }
}
