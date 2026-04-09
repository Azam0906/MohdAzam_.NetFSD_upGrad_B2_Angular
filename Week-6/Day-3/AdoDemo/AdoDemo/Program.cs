using AdoDemo.Entity;
using AdoDemo.DataAccess;
using Microsoft.Extensions.Configuration;

namespace AdoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string connStr = config.GetConnectionString("DefaultConnection");

            ProductRepository repo = new ProductRepository(connStr);

            while (true)
            {
                Console.WriteLine("\n===== PRODUCT MENU =====");
                Console.WriteLine("1. Insert Product");
                Console.WriteLine("2. View All Products");
                Console.WriteLine("3. Update Product");
                Console.WriteLine("4. Delete Product");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                int choice = int.Parse(Console.ReadLine());

                try
                {
                    switch (choice)
                    {
                        case 1:
                            Insert(repo);
                            break;

                        case 2:
                            View(repo);
                            break;

                        case 3:
                            Update(repo);
                            break;

                        case 4:
                            Delete(repo);
                            break;

                        case 5:
                            return;

                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        static void Insert(ProductRepository repo)
        {
            Product p = new Product();

            Console.Write("Enter Product Name: ");
            p.ProductName = Console.ReadLine();

            Console.Write("Enter Category: ");
            p.Category = Console.ReadLine();

            Console.Write("Enter Price: ");
            p.Price = decimal.Parse(Console.ReadLine());

            int result = repo.AddProduct(p);

            Console.WriteLine(result > 0 ? "Inserted Successfully" : "Insert Failed");
        }

        static void View(ProductRepository repo)
        {
            var products = repo.GetAllProducts();

            Console.WriteLine("\n--- Product List ---");

            foreach (var p in products)
            {
                Console.WriteLine($"{p.ProductId} | {p.ProductName} | {p.Category} | {p.Price}");
            }
        }

        static void Update(ProductRepository repo)
        {
            Product p = new Product();

            Console.Write("Enter Product Id: ");
            p.ProductId = int.Parse(Console.ReadLine());

            Console.Write("Enter New Name: ");
            p.ProductName = Console.ReadLine();

            Console.Write("Enter New Category: ");
            p.Category = Console.ReadLine();

            Console.Write("Enter New Price: ");
            p.Price = decimal.Parse(Console.ReadLine());

            int result = repo.UpdateProduct(p);

            Console.WriteLine(result > 0 ? "Updated Successfully" : "Update Failed");
        }

        static void Delete(ProductRepository repo)
        {
            Console.Write("Enter Product Id: ");
            int id = int.Parse(Console.ReadLine());

            int result = repo.DeleteProduct(id);

            Console.WriteLine(result > 0 ? "Deleted Successfully" : "Delete Failed");
        }
    }
}