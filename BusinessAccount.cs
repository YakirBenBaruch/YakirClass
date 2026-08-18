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

        public static void UnitTest()
        {
            BusinessAccount account1 = new BusinessAccount(1, 123, 456789, "ID123", "MyBusiness", 1000, 5000);

            Console.WriteLine("GetBusinessName: " + (account1.GetBusinessName() == "MyBusiness"));
            Console.WriteLine("GetOverDraftLimit: " + (account1.GetOverDraftLimit() == 1000));
            Console.WriteLine("GetMortgageLimit: " + (account1.GetMortgageLimit() == 5000));

            account1.SetBusinessName("UpdatedBusiness");

            Console.WriteLine("SetBusinessName: " + (account1.GetBusinessName() == "UpdatedBusiness"));
            Console.WriteLine("Set negative mortgage limit: " + (account1.SetMortgageLimit(-100) == false));
            Console.WriteLine("Mortgage unchanged: " + (account1.GetMortgageLimit() == 5000));
            Console.WriteLine("Set mortgage limit: " + (account1.SetMortgageLimit(2000) == true));
            Console.WriteLine("New mortgage limit: " + (account1.GetMortgageLimit() == 2000));
            Console.WriteLine("Deposit 2000: " + (account1.Deposit(2000) == true));
            Console.WriteLine("Withdraw zero: " + (account1.Withdraw(0) == false));
            Console.WriteLine("Withdraw negative amount: " + (account1.Withdraw(-100) == false));
            Console.WriteLine("Withdraw to exact limit: " + (account1.Withdraw(5000) == true));
            Console.WriteLine("Balance at exact limit: " + (account1.GetAccountBalance() == -3000));
            Console.WriteLine("Withdraw over limit: " + (account1.Withdraw(1) == false));
            Console.WriteLine("Balance after failed withdrawal: " + (account1.GetAccountBalance() == -3000));
            Console.WriteLine("AtRisk with negative balance: " + (account1.AtRisk() == false));
            Console.WriteLine("ToString: " + account1.ToString().Contains("UpdatedBusiness"));

            BusinessAccount defaultAccount = new BusinessAccount(2, 456, 987654, "ID456", "DefaultBusiness");

            Console.WriteLine("Default overdraft limit: " + (defaultAccount.GetOverDraftLimit() == 500));
            Console.WriteLine("Default mortgage limit: " + (defaultAccount.GetMortgageLimit() == 0));

            BusinessAccount invalidLimitsAccount = new BusinessAccount(3, 789, 123456, "ID789", "InvalidLimits", -1000, -5000);

            Console.WriteLine("Invalid overdraft becomes default: " + (invalidLimitsAccount.GetOverDraftLimit() == 500));
            Console.WriteLine("Invalid mortgage becomes zero: " + (invalidLimitsAccount.GetMortgageLimit() == 0));

            BusinessAccount riskAccount = new BusinessAccount(4, 111, 222333, "ID111", "RiskBusiness", 1000, 0);

            Console.WriteLine("Initial AtRisk: " + (riskAccount.AtRisk() == false));
            Console.WriteLine("Deposit 900: " + (riskAccount.Deposit(900) == true));
            Console.WriteLine("AtRisk at 90 percent: " + (riskAccount.AtRisk() == true));

            BusinessAccount salaryAccount = new BusinessAccount(5, 222, 333444, "ID222", "SalaryBusiness", 1000, 0);
            CheckingAccount checkingAccount = new CheckingAccount(6, 333, 444555, "ID333", 500);

            Console.WriteLine("Deposit before salary transfer: " + (salaryAccount.Deposit(1000) == true));
            Console.WriteLine("Transfer salary: " + (salaryAccount.TransferSalary(300, checkingAccount) == true));
            Console.WriteLine("Business balance after transfer: " + (salaryAccount.GetAccountBalance() == 700));
            Console.WriteLine("Checking balance after transfer: " + (checkingAccount.GetAccountBalance() == 300));
            Console.WriteLine("Transfer zero salary: " + (salaryAccount.TransferSalary(0, checkingAccount) == false));
            Console.WriteLine("Transfer salary over limit: " + (salaryAccount.TransferSalary(2000, checkingAccount) == false));
            Console.WriteLine("Business balance after failed transfer: " + (salaryAccount.GetAccountBalance() == 700));
            Console.WriteLine("Checking balance after failed transfer: " + (checkingAccount.GetAccountBalance() == 300));
        }
    }
}