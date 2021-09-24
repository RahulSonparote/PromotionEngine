using ProductPromotions.Models;
using ProductPromotions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductPromotions
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            var productService = new ProductService();
            Console.WriteLine("Welcome to promotion Engine.");
            Console.WriteLine("Order Ex :If you want to enter 3 A, Press 3 as total order and enter A for 3 times");
            Console.WriteLine("          If you want to enter 3 A and 2B, Press 5 as total order and enter A for 3 times and B for 2 times");

            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
            Console.Write("Enter total orders  : ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.Write("Enter type of product:A,B,C or D : ");
                string type = Console.ReadLine();
                Product p = new Product
                {
                    Id = type
                };
                products.Add(p);
            }

            int totalPrice = productService.GetTotalPrice(products);
            Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

            Console.WriteLine("Total Price : " +totalPrice);
            Console.ReadLine();
        }
    }
}
