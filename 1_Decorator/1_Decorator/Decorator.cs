using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Decorator
{
    public abstract class Decorator : Car
    {
        protected Car car;

        public Decorator(Car car)
        {
            this.car = car;
        }

        public override void Drive()
        {
            if (car != null)
            {
                car.Drive();
            }
        }
    }
}
