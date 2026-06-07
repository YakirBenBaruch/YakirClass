using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class BusinessAccount : BasicAccount
    {
        private string BusinessName;
        private double OverDraftLimit;
        private double MortgageLimit;

        public BusinessAccount(int numOfBankAccounts, int numOfBranchNumber, int accountNumber, string ownersID, string businessName) : base(numOfBankAccounts, numOfBranchNumber, accountNumber, ownersID)
        {
            this.BusinessName = businessName;
            this.OverDraftLimit = 500;
            this.MortgageLimit = 0;
        }

        public BusinessAccount(int numOfBankAccounts, int numOfBranchNumber, int accountNumber, string ownersID, string businessName, double overDraftLimit, double mortgageLimit) : base(numOfBankAccounts, numOfBranchNumber, accountNumber, ownersID)
        {
            this.BusinessName = businessName;

            if (overDraftLimit >= 0)
                this.OverDraftLimit = overDraftLimit;
            else
                this.OverDraftLimit = 500;

            if (mortgageLimit >= 0)
                this.MortgageLimit = mortgageLimit;
            else
                this.MortgageLimit = 0;
        }

        public string GetBusinessName()
        {
            return BusinessName;
        }

        public double GetOverDraftLimit()
        {
            return OverDraftLimit;
        }

        public double GetMortgageLimit()
        {
            return MortgageLimit;
        }

        public void SetBusinessName(string businessName)
        {
            this.BusinessName = businessName;
        }

        public bool SetMortgageLimit(double mortgageLimit)
        {
            if (mortgageLimit < 0)
            {
                return false;
            }

            this.MortgageLimit = mortgageLimit;
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            if (this.AccountBalance - amount < -(this.OverDraftLimit + this.MortgageLimit))
            {
                return false;
            }

            this.AccountBalance -= amount;
            return true;
        }

        public bool TransferSalary(double amount, CheckingAccount checkingAccount)
        {
            if (amount <= 0)
            {
                return false;
            }

            if (this.Withdraw(amount) == false)
            {
                return false;
            }

            checkingAccount.Deposit(amount);
            return true;
        }

        public override string ToString()
        {
            return base.ToString() +
                   "\nBusiness name: " + BusinessName +
                   "\nOverdraft limit: " + OverDraftLimit +
                   "\nMortgage limit: " + MortgageLimit;
        }

        public static void UnitTest()
        {
            BusinessAccount businessAccount1 = new BusinessAccount(1, 123, 456789, "ID123", "MyBusiness", 1000, 5000);
            Console.WriteLine(businessAccount1);
            Console.WriteLine("Deposit 2000: " + businessAccount1.Deposit(2000));
            Console.WriteLine("Withdraw 6000: " + businessAccount1.Withdraw(6000));
            Console.WriteLine("Withdraw 7000: " + businessAccount1.Withdraw(7000));
            Console.WriteLine(businessAccount1);
            CheckingAccount checkingAccount1 = new CheckingAccount(2, 456, 987654, "ID456", 500);
            Console.WriteLine(checkingAccount1);
            Console.WriteLine("Transfer salary of 3000 to checking account: " + businessAccount1.TransferSalary(3000, checkingAccount1));
            Console.WriteLine(businessAccount1);
            Console.WriteLine(checkingAccount1);
        }
    }
}