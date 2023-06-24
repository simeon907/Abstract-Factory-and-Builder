using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Track : Component
    {
        public Track(string title) : base(title)
        {
        }

        public override void Play(int depth)
        {
            Console.WriteLine(new string('-', depth) + title + " is playing");
        }
    }
}
