using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Facade
{
    public class AccountNumberCheck
    {
        int accountNumber = 12345678;

        public bool IsNumberCorrect(int number)
        {
            return accountNumber == number;
        }
    }
}
