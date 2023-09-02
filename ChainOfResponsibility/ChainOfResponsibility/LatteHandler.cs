using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class LatteHandler : CoffeeHandler
    {
        public override void HandleRequest(CoffeeOrder order)
        {
            if(order.CoffeeType==CoffeeType.Latte)
            {
                Console.WriteLine("Make Latte");
            }
            else
            {
                successor.HandleRequest(order);
            }
        }
    }
}
