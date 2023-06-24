using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TVImplementation tv = new ConcreteTVImplementation();
            RemoteControl remoteControl = new ConcreteRemoteControl(tv);

            remoteControl.PressPowerButton();
            remoteControl.PressVolumeUpButton();
            Console.ReadKey();
        }
    }
}
