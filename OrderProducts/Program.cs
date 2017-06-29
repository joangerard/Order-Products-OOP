using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product("A122", "bread", 4);
            Product p2 = new Product("C123", "pencil", 3);
            Product p3 = new Product("D121", "bread", 4);

            ProductList products = new ProductList();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("_____________________");
                Console.WriteLine("1 By Code");
                Console.WriteLine("2 By Name");
                Console.WriteLine("3 By Stock");
                Console.WriteLine("Your options: ");

                string options = Console.ReadLine();

                Translator translator = new Translator(3);
                List<IOrderManager> orders = translator.Translate(options);
                Console.WriteLine();
                Console.WriteLine("RESULT: ");
                products.Order(orders[0], orders[1], orders[2]);
                products.Show();

            }
            

            Console.Read();
        }
    }
}
