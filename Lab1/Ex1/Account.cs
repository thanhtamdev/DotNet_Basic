using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Account
    {
        private int AccountNumber;
        private int AmountOfMoney;

        /*
         * constructor
         */
        public Account(int s, int a)
        {
            AccountNumber = s;
            AmountOfMoney = a;
        }

        /*
         * Get, Set
         */

        public void SetAccountNumber(int acc)
        {
            AccountNumber = acc;
        }

        public int GetAccountNumber()
        {
            return AccountNumber;
        }

        // Get, Set AmountOfMoney

        public void SetAmountOfNumber(int a)
        {
            AmountOfMoney = a;
        }

        public int GetAmountOfMoney()
        {
            return AmountOfMoney;
        }

    }
}
