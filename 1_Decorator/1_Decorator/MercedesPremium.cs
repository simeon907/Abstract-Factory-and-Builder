using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Decorator
{
    public class MercedesPremium : Decorator
    {
        private readonly bool _leatherSeatings;
        public MercedesPremium(Car car) : base(car)
        {
            _leatherSeatings = true;
        }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine("leather seatings");
        }

        public override void Complectation()
        {
            Console.WriteLine("Premium complectation");
        }
    }
}
