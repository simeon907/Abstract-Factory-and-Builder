using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    internal class Client
    {
        private AbstractCar car;

        public Client(MercedesFactory factory)
        {
            car = factory.CreateCar();
        }

        public void Show()
        {
            Console.WriteLine(car);
        }
    }
}
