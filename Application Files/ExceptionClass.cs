using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplicationIteration2
{
    public class ExceptionClass : Exception
    {
        public ExceptionClass(double message, double message2) : base(String.Format("Cannot take ",message, " from account balance: ", message2))
        {

        }


    }
}
