using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccountFacade facade = new BankAccountFacade(12345678, 1234);

            facade.WithdrawCash(50);
            facade.WithdrawCash(900);
            facade.WithdrawCash(200);

            facade.DepositCash(300);

            Console.ReadKey();
        }
    }
}
