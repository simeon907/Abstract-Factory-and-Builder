using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class EspressoHandler : CoffeeHandler
    {
        public override void HandleRequest(CoffeeOrder order)
        {
            if(order.CoffeeType==CoffeeType.Espresso)
            {
                Console.WriteLine("Make Espresso");
            }
            else if(successor!=null)
            {
                successor.HandleRequest(order);
            }
        }
    }
}
