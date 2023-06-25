using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Facade
{
    public class BankAccountFacade
    {
        private int _accountNumber;
        private int _securityCode;

        private AccountNumberCheck _numberChecker;
        private SecurityCodeCheck _codeChecker;
        private FundsCheck _fundChecker;
        private WelcomeBank _bankWelcome;

        public BankAccountFacade(int newNumber, int newCode)
        {
            _accountNumber = newNumber;
            _securityCode = newCode;

            _bankWelcome = new WelcomeBank();
            _numberChecker = new AccountNumberCheck();
            _codeChecker = new SecurityCodeCheck();
            _fundChecker = new FundsCheck();
        }

        public void WithdrawCash(double cash) // èçüÿòèå(ïîëó÷åíèå) äåíåã
        {
            if (_numberChecker.IsNumberCorrect(_accountNumber) &&
                _codeChecker.IsCodeCorrect(_securityCode) &&
                _fundChecker.WhetherCash(cash))
            {
                Console.WriteLine("Success transaction.\n");
            }
            else
            {
                Console.WriteLine("Transaction is declined.\n");
            }
        }

        public void DepositCash(double deposit) // ïîïîëíåíèå ñ÷åòà
        {
            if (_numberChecker.IsNumberCorrect(_accountNumber) &&
                _codeChecker.IsCodeCorrect(_securityCode))
            {
                _fundChecker.MakeDeposit(deposit);
                Console.WriteLine("Success transaction.\n");
            }
            else
            {
                Console.WriteLine("Transaction is declined.\n");
            }
        }
    }
}
