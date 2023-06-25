using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Decorator
{
    public class MercedesMedium : Decorator
    {
        private bool _seatHeating;
        public MercedesMedium(Car car) : base(car)
        {
            _seatHeating = true;
        }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("seat heating");
        }

        public override void Complectation()
        {
            Console.WriteLine("Medium complectation");
        }

        public void SwitchHeatingOn()
        {
            Console.WriteLine("Seat heating is on");
        }

        public void SwitchHeatingOff()
        {
            Console.WriteLine("Seat heating is off");
        }
    }
}
