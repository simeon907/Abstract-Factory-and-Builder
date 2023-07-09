using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class CoffeeMachine
    {
        private CoffeeHandler _coffeeHandler;

        public CoffeeMachine()
        {
            EspressoHandler espressoHandler = new EspressoHandler();
            LatteHandler latteHandler = new LatteHandler();
            CappuccinoHandler cappuccinoHandler = new CappuccinoHandler();

            espressoHandler.SetSuccessor(latteHandler);
            latteHandler.SetSuccessor(cappuccinoHandler);

            _coffeeHandler = espressoHandler;
        }

        public void MakeCoffee(CoffeeOrder coffeeOrder)
        {
            _coffeeHandler.HandleRequest(coffeeOrder);
        }
    }
}
