using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class BasicAccount
    {
        private int NumOfBankAccounts;
        private int NumOfBranchNumber;
        private int AccountNumber;
        private string OwnersID;
        private double AccountBalance = 0;

        public int GetNumOfBankAccounts()
        {
            return NumOfBankAccounts;
        }

        public int GetNumOfBranchNumber()
        {
            return NumOfBranchNumber;
        }

        public int GetAccountNumber()
        {
            return AccountNumber;
        }

        public string GetOwnersID()
        {
            return OwnersID;
        }

        public double GetAccountBalance()
        {
            return AccountBalance;
        }

        public bool Deposit(double amount)
        {
            if (amount < 0)
            {
                return false;
            }

            this.AccountBalance += amount;

            return true;
        }
    }
}
