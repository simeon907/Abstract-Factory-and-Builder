using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CoffeeMachine machine = new CoffeeMachine();

            CoffeeOrder order = new CoffeeOrder() { CoffeeType=CoffeeType.Espresso};
            machine.MakeCoffee(order);

            order = new CoffeeOrder() { CoffeeType = CoffeeType.Latte };
            machine.MakeCoffee(order);

            order = new CoffeeOrder() { CoffeeType = CoffeeType.Cappuccino };
            machine.MakeCoffee(order);

            order = new CoffeeOrder() { CoffeeType=CoffeeType.Espresso };
            machine.MakeCoffee(order);

            Console.ReadKey();
        }
    }
}
