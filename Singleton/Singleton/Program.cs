using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine m = Magazine.Instance;

            m.Comment("Hello");

            Console.WriteLine("Comment was written");

            Console.ReadKey();
        }
    }
}
