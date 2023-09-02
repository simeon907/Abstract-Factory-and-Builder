using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _3_Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>() { "barbarian", "archer", "barbarian", "archer", "wizard"};

            CharacterFactory factory = new CharacterFactory();

            foreach (string str in list)
            {
                factory.GetCharacter(str).Display();
            }

            Console.ReadKey();
        }
    }
}
