using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Facade
{
    public class FundsCheck
    {
        double cashAccount = 1000.0;

        public void DecreaseCash(double cash)
        {
            cashAccount -= cash;
            Console.WriteLine("Decreased on " + cash);
        }

        public void IncreaseCash(double cash)
        {
            cashAccount += cash;
            Console.WriteLine("Increased on " + cash);
        }

        public bool WhetherCash(double cash)
        {
            if (cash > cashAccount)
            {
                Console.WriteLine("Funds are not enough");
                Console.WriteLine("Current balance: " + cashAccount);

                return false;
            }
            else
            {
                DecreaseCash(cash);
                Console.WriteLine("Current balance: " + cashAccount);

                return true;
            }
        }

        public void MakeDeposit(double deposit) // îôîðìèòü äåïîçèò
        {
            IncreaseCash(deposit);

            Console.WriteLine("Deposit has been made. Current balance: " + cashAccount);
        }
    }
}
