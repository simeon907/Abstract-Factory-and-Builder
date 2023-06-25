using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Facade
{
    public class SecurityCodeCheck
    {
        int pinCode = 1234;

        public bool IsCodeCorrect(int code)
        {
            return pinCode == code;
        }
    }
}
