using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Decorator
{
    public class Mercedes : Car
    {
        public override void Drive()
        {
            Console.WriteLine("Includes:");
            Console.WriteLine("Wheels");
        }
    }
}
