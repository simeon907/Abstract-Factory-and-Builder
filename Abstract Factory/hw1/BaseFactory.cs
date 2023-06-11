using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1
{
    public class BaseFactory : MercedesFactory
    {
        public override AbstractCar CreateCar()
        {
            return new EClass();
        }
    }
}
