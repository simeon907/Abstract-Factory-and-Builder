using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1._1
{
    public class HappyMeal
    {
        public string Size { get; set; }
        public string MainItem { get; set; }
        public string Drink { get; set; }
        public string Toy { get; set; }

        public void Display()
        {
            Console.WriteLine($"Size: {Size}");
            Console.WriteLine($"Main Item: {MainItem}");
            Console.WriteLine($"Drink: {Drink}");
            Console.WriteLine($"Toy: {Toy}\n");
        }
    }
}
