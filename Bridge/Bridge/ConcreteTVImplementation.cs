using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ConcreteTVImplementation : TVImplementation
    {
        public override void TogglePower()
        {
            Console.WriteLine("Turn on/off TV");
        }

        public override void IncreaseVolume()
        {
            Console.WriteLine("Increase TV volume");
        }

        public override void DecreaseVolume()
        {
            Console.WriteLine("Decrease TV volume");
        }
    }
}
