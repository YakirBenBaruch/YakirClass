using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class BasicAccount
    {
        protected int NumOfBankAccounts;
        protected int NumOfBranchNumber;
        protected int AccountNumber;
        protected string OwnersID;
        protected double AccountBalance;

        public BasicAccount(int numOfBankAccounts, int numOfBranchNumber, int accountNumber, string ownersID)
        {
            this.NumOfBankAccounts = numOfBankAccounts;
            this.NumOfBranchNumber = numOfBranchNumber;
            this.AccountNumber = accountNumber;
            this.OwnersID = ownersID;
            this.AccountBalance = 0;
        }

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
            if (amount <= 0)
            {
                return false;
            }

            this.AccountBalance += amount;
            return true;
        }

        public override string ToString()
        {
            return "Bank account number: " + NumOfBankAccounts +
                   "\nBranch number: " + NumOfBranchNumber +
                   "\nAccount number: " + AccountNumber +
                   "\nOwner's ID: " + OwnersID +
                   "\nAccount balance: " + AccountBalance;
        }
    }
}
