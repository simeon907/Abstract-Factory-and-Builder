using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component root = new Album("Album 0");

            root.Add(new Track("Track 01"));
            root.Add(new Track("Track 02"));

            Component alb1 = new Album("Album 1");

            alb1.Add(new Track("Track 11"));
            alb1.Add(new Track("Track 12"));

            Component alb2 = new Album("Album 3");
            alb2.Add(new Track("Track 31"));
            alb2.Add(new Track("Track 32"));
            alb2.Add(new Track("Track 33"));
            alb1.Add(alb2);

            root.Add(alb1);
            root.Add(new Track("Track 03"));
            root.Add(new Track("Track 04"));

            root.Play(1);

            Console.Read();
        }
    }
}
