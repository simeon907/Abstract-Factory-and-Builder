using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MercedesFactory economyFactory = new EconomyFactory();
            Client c1 = new Client(economyFactory);
            Console.WriteLine("Economy factory");
            c1.Show();
            Console.WriteLine("\n");

            MercedesFactory baseFactory = new EconomyFactory();
            Client c2 = new Client(baseFactory);
            Console.WriteLine("Base factory");
            c2.Show();
            Console.WriteLine("\n");

            MercedesFactory luxuryFactory = new EconomyFactory();
            Client c3 = new Client(luxuryFactory);
            Console.WriteLine("Luxury factory");
            c3.Show();
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}
