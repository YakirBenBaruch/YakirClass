
using System;

namespace Yakir
{
    public class BusinessAccount : BasicAccount, IComparable
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
                return false;

            this.MortgageLimit = mortgageLimit;
            return true;
        }

        public override bool Withdrawal(object o)
        {
            double amount = (double)o;

            if (amount <= 0)
                return false;

            if (AccountBalance - amount < -(OverDraftLimit + MortgageLimit))
                return false;

            AccountBalance -= amount;
            return true;
        }

        public bool TransferSalary(double amount, CheckingAccount checkingAccount)
        {
            if (amount <= 0 || checkingAccount == null)
                return false;

            if (Withdrawal(amount) == false)
                return false;

            checkingAccount.Deposit(amount);
            return true;
        }

        public int CompareTo(object obj)
        {
            BusinessAccount other = (BusinessAccount)obj;

            double wealth1 = AccountBalance + OverDraftLimit;
            double wealth2 = other.AccountBalance + other.OverDraftLimit;

            return wealth1.CompareTo(wealth2);
        }

        public override bool AtRisk()
        {
            return AccountBalance == OverDraftLimit * 0.9;
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
            BusinessAccount account = new BusinessAccount(1, 123, 456789, "ID123", "MyBusiness", 1000, 5000);

            Console.WriteLine("GetBusinessName: " + (account.GetBusinessName() == "MyBusiness"));
            Console.WriteLine("GetOverDraftLimit: " + (account.GetOverDraftLimit() == 1000));
            Console.WriteLine("GetMortgageLimit: " + (account.GetMortgageLimit() == 5000));

            account.SetBusinessName("NewBusiness");
            Console.WriteLine("SetBusinessName: " + (account.GetBusinessName() == "NewBusiness"));

            Console.WriteLine("Invalid mortgage: " + (account.SetMortgageLimit(-100) == false));
            Console.WriteLine("Mortgage unchanged: " + (account.GetMortgageLimit() == 5000));
            Console.WriteLine("Valid mortgage: " + (account.SetMortgageLimit(2000) == true));
            Console.WriteLine("New mortgage: " + (account.GetMortgageLimit() == 2000));

            Console.WriteLine("Deposit: " + (account.Deposit(2000) == true));
            Console.WriteLine("Withdrawal zero: " + (account.Withdrawal(0.0) == false));
            Console.WriteLine("Withdrawal negative: " + (account.Withdrawal(-100.0) == false));
            Console.WriteLine("Withdrawal 5000: " + (account.Withdrawal(5000.0) == true));
            Console.WriteLine("Balance: " + (account.GetAccountBalance() == -3000));
            Console.WriteLine("Withdrawal over limit: " + (account.Withdrawal(1.0) == false));
            Console.WriteLine("AtRisk: " + (account.AtRisk() == false));
            Console.WriteLine("ToString: " + account.ToString().Contains("NewBusiness"));

            BusinessAccount defaultAccount = new BusinessAccount(2, 456, 987654, "ID456", "Default");
            Console.WriteLine("Default overdraft: " + (defaultAccount.GetOverDraftLimit() == 500));
            Console.WriteLine("Default mortgage: " + (defaultAccount.GetMortgageLimit() == 0));

            BusinessAccount invalidAccount = new BusinessAccount(3, 789, 123456, "ID789", "Invalid", -1000, -5000);
            Console.WriteLine("Invalid overdraft becomes 500: " + (invalidAccount.GetOverDraftLimit() == 500));
            Console.WriteLine("Invalid mortgage becomes 0: " + (invalidAccount.GetMortgageLimit() == 0));

            BusinessAccount small = new BusinessAccount(4, 100, 111, "ID1", "Small", 500, 0);
            BusinessAccount large = new BusinessAccount(5, 100, 222, "ID2", "Large", 1000, 0);
            BusinessAccount equal = new BusinessAccount(6, 100, 333, "ID3", "Equal", 1000, 3000);

            Console.WriteLine("CompareTo greater: " + (large.CompareTo(small) > 0));
            Console.WriteLine("CompareTo smaller: " + (small.CompareTo(large) < 0));
            Console.WriteLine("CompareTo equal: " + (large.CompareTo(equal) == 0));

            BusinessAccount riskAccount = new BusinessAccount(7, 100, 444, "ID4", "Risk", 1000, 0);
            Console.WriteLine("Initial risk: " + (riskAccount.AtRisk() == false));
            riskAccount.Deposit(900);
            Console.WriteLine("AtRisk at 900: " + (riskAccount.AtRisk() == true));

            BusinessAccount salaryAccount = new BusinessAccount(8, 100, 555, "ID5", "Salary", 1000, 0);
            CheckingAccount checking = new CheckingAccount(9, 100, 666, "ID6", 500);

            salaryAccount.Deposit(1000);

            Console.WriteLine("TransferSalary: " + (salaryAccount.TransferSalary(300, checking) == true));
            Console.WriteLine("Business balance: " + (salaryAccount.GetAccountBalance() == 700));
            Console.WriteLine("Checking balance: " + (checking.GetAccountBalance() == 300));
            Console.WriteLine("Transfer zero: " + (salaryAccount.TransferSalary(0, checking) == false));
            Console.WriteLine("Transfer negative: " + (salaryAccount.TransferSalary(-100, checking) == false));
            Console.WriteLine("Transfer over limit: " + (salaryAccount.TransferSalary(2000, checking) == false));
            Console.WriteLine("Transfer to null: " + (salaryAccount.TransferSalary(100, null) == false));
            Console.WriteLine("Balance after failed transfers: " + (salaryAccount.GetAccountBalance() == 700));
        }
    }
}
