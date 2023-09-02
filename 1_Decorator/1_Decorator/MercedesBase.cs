using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Decorator
{
    public class MercedesBase : Decorator
    {
        private string _conditioner;
        public MercedesBase(Car car) : base(car)
        {
            _conditioner = "Super conditioner 2000";
        }

        public override void Drive()
        {
            base.Drive();
            Console.WriteLine(_conditioner);
        }

        public override void Complectation()
        {
            Console.WriteLine("Base complectation");
        }
    }
}
