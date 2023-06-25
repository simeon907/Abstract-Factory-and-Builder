using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Decorator
{
    public abstract class Car
    {
        public abstract void Drive();
        public virtual void Complectation() { }
    }
}
