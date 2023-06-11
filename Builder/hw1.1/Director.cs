using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw1._1
{
    public class Director
    {
        public void Construct(IHappyMealBuilder builder)
        {
            builder.SetSize();
            builder.SetMainItem();
            builder.SetDrink();
            builder.SetToy();
        }
    }
}
