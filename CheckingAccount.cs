using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class CheckingAccount
    {
        private int NumOfBankAccounts;
        private int NumOfBranchNumber;
        private int AccountNumber;
        private string OwnersID;
        private double AccountBalance = 0;
        private double OverDraftLimit;
        const double DefaultOverDraftLimit = 500;

        public CheckingAccount(int numOfBankAccounts, int numOfBranchNumber, int accountNumber, string ownersID, double overDraftLimit)
        {
            this.NumOfBankAccounts = numOfBankAccounts;
            this.NumOfBranchNumber = numOfBranchNumber;
            this.AccountNumber = accountNumber;
            this.OwnersID = ownersID;
            this.AccountBalance = 0;
            this.OverDraftLimit = overDraftLimit;
        }

        public CheckingAccount(int numOfBankAccounts, int numOfBranchNumber, int accountNumber, string ownersID) : this(numOfBankAccounts, numOfBranchNumber, accountNumber, ownersID, CheckingAccount.DefaultOverDraftLimit) { }

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

        public void SetOverDraftLimit(double NewOverDraftLimit)
        {
            this.OverDraftLimit = NewOverDraftLimit;
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

        public bool Withdraw(double amount)
        {
            if (amount < 0 || this.AccountBalance - amount < -DefaultOverDraftLimit)
            {
                return false;
            }

            this.AccountBalance -= amount;

            return true;
        }

        public override string ToString()
        {
            return "Bank account number: " + NumOfBankAccounts + "\nBranch number: " + NumOfBranchNumber + "\nAccount number: " + AccountNumber + "\nOwner's ID: " + OwnersID + "\nAccount balance: " + AccountBalance + "\nOverdraft limit: " + OverDraftLimit;
        }
    }
}
