



using Container;
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
            StoreFacade storeFacade = new StoreFacade(new ViewerConsole());
            storeFacade.InitProducts();
            storeFacade.InitBooks();
            storeFacade.ShowAllBooks();
            storeFacade.ShowAllProducts();

            ConsoleKeyInfo key = new ConsoleKeyInfo();

            while (key.Key != ConsoleKey.X)
            {
                storeFacade.ShowMenu();
                storeFacade.ReadClientChoice();
                storeFacade.Order();

                storeFacade.ShowAllBooks();
                storeFacade.ShowAllProducts();

                key = Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
