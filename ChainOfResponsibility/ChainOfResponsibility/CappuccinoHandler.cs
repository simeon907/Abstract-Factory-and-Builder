using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class CappuccinoHandler : CoffeeHandler
    {
        public override void HandleRequest(CoffeeOrder order)
        {
            if(order.CoffeeType==CoffeeType.Cappuccino)
            {
                Console.WriteLine("Make Cappuccino");
            }
            else
            {
                Console.WriteLine("error wrong coffee");
            }
        }
    }
}
