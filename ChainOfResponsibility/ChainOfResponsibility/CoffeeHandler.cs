using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public abstract class CoffeeHandler
    {
        protected CoffeeHandler successor;

        public void SetSuccessor(CoffeeHandler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(CoffeeOrder order);
    }
}
