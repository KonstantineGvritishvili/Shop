using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICrud crud = new Crud();
            while (true)
            {
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. See All Products");
                Console.WriteLine("3. See Product By Id");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Delete Product");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Product Name: ");
                        string prName = Console.ReadLine();
                        Console.Write("Enter Product Price: ");
                        decimal price = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter Product Manufacturer: ");
                        string prManufacturer = Console.ReadLine();

                        Product product = new Product
                        {
                            PrName = prName,
                            Price = price,
                            PrManufacturer = prManufacturer
                        };

                        crud.AddProduct(product);
                        break;

                    case 2:
                        foreach (var p in crud.GetAllProducts())
                        {
                            Console.WriteLine($"Id: {p.Id}, Name: {p.PrName}, Price: {p.Price}, Manufacturer: {p.PrManufacturer}");
                        }
                        break;

                    case 3:
                        Console.Write("Enter Product Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Product productById = crud.FindProductById(id);
                        if (productById != null)
                        {
                            Console.WriteLine($"Id: {productById.Id}, Name: {productById.PrName}, Price: {productById.Price}, Manufacturer: {productById.PrManufacturer}");
                        }
                        else
                        {
                            Console.WriteLine("Product not found");
                        }
                        break;

                    case 4:
                        Console.Write("Enter Product Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        productById = crud.FindProductById(id);
                        if (productById != null)
                        {
                            Console.Write("Enter new Product Name: ");
                            prName = Console.ReadLine();
                            Console.Write("Enter new Product Price: ");
                            price = Convert.ToDecimal(Console.ReadLine());
                            Console.Write("Enter new Product Manufacturer: ");
                            prManufacturer = Console.ReadLine();

                            productById.PrName = prName;
                            productById.Price = price;
                            productById.PrManufacturer = prManufacturer;

                            crud.UpdateProduct(productById);
                        }
                        else
                        {
                            Console.WriteLine("Product not found");
                        }
                        break;

                    case 5:
                        Console.Write("Enter Product Id: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteProduct(id);
                        break;
                    case 6:
                        Console.WriteLine("Sort products By Manufacturer: ");
                        prName = new ;
                        break;
                    case 9:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
