using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Flyweight
{
    public class Default : Character
    {
        public Default() 
        {
            name = "???";
        }

        public override void Display()
        {
            Console.WriteLine(name);
        }
    }
}
