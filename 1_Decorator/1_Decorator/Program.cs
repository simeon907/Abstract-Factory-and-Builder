using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MercedesPremium mercedesPremium = new MercedesPremium(new MercedesMedium(new MercedesBase(new Mercedes())));
            mercedesPremium.Complectation();
            mercedesPremium.Drive();
            Console.ReadKey();
        }
    }
}
