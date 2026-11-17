
using System;

namespace Yakir
{
    public class BusinessAccount : BasicAccount, IComparable
    {
        private string BusinessName;
        private double OverDraftLimit;
        private double MortgageLimit;

        public BusinessAccount(int numOfBankAccounts, int numOfBranchNumber,
            int accountNumber, string ownersID, string businessName)
            : base(numOfBankAccounts, numOfBranchNumber, accountNumber, ownersID)
        {
            this.BusinessName = businessName;
            this.OverDraftLimit = 500;
            this.MortgageLimit = 0;
        }

        public BusinessAccount(int numOfBankAccounts, int numOfBranchNumber,
            int accountNumber, string ownersID, string businessName,
            double overDraftLimit, double mortgageLimit)
            : base(numOfBankAccounts, numOfBranchNumber, accountNumber, ownersID)
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

            if (this.AccountBalance - amount <
                -(this.OverDraftLimit + this.MortgageLimit))
            {
                return false;
            }

            this.AccountBalance -= amount;
            return true;
        }

        public override bool Withdrawal(object o)
        {
            if (o is double || o is int)
            {
                return Withdraw(Convert.ToDouble(o));
            }

            return false;
        }

        public bool TransferSalary(double amount, CheckingAccount checkingAccount)
        {
            if (amount <= 0 || checkingAccount == null)
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

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (!(obj is BusinessAccount))
            {
                throw new ArgumentException("Object must be BusinessAccount");
            }

            BusinessAccount other = (BusinessAccount)obj;

            double wealth1 = this.AccountBalance + this.OverDraftLimit;
            double wealth2 = other.AccountBalance + other.OverDraftLimit;

            return wealth1.CompareTo(wealth2);
        }

        public override bool AtRisk()
        {
            if (this.AccountBalance == this.OverDraftLimit * 0.9)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return base.ToString() +
                   "\nBusiness name: " + BusinessName +
                   "\nOverdraft limit: " + OverDraftLimit +
                   "\nMortgage limit: " + MortgageLimit;
        }
    }
}
