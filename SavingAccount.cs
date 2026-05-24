using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class SavingAccount
    {
        private int NumOfBankAccounts;
        private int NumOfBranchNumber;
        private int AccountNumber;
        private string OwnersID;
        private double AccountBalance;
        private Date ExpiryDateOfSaving;

        public SavingAccount(int numOfBankAccounts, int numOfBranchNumber, int accountNumber,
                             string ownersID, double accountBalance, Date expiryDateOfSaving)
        {
            NumOfBankAccounts = numOfBankAccounts;
            NumOfBranchNumber = numOfBranchNumber;
            AccountNumber = accountNumber;
            OwnersID = ownersID;
            AccountBalance = accountBalance;
            ExpiryDateOfSaving = new Date(expiryDateOfSaving);
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

        public void SetExpiryDateOfSaving(Date expiryDateOfSaving)
        {
            this.ExpiryDateOfSaving = new Date(expiryDateOfSaving);
        }

        public bool Deposit(double amount)
        {
            if (amount > 0)
            {
                AccountBalance += amount;
                return true;
            }

            return false;
        }

        public bool Withdrawal(double amount, Date withdrawalDate)
        {
            if (amount <= AccountBalance && withdrawalDate.CompareTo(ExpiryDateOfSaving) >= 0)
            {
                AccountBalance -= amount;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return "Bank number: " + NumOfBankAccounts +
                   "\nBranch number: " + NumOfBranchNumber +
                   "\nAccount number: " + AccountNumber +
                   "\nOwner ID: " + OwnersID +
                   "\nAccount balance: " + AccountBalance +
                   "\nExpiry date of saving: " + ExpiryDateOfSaving;
        }
    }
}