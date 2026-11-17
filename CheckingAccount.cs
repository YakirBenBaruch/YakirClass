
using System;

namespace Yakir
{
    public class CheckingAccount : BasicAccount
    {
        private double OverDraftLimit;
        const double DefaultOverDraftLimit = 500;

        public CheckingAccount(int numOfBankAccounts, int numOfBranchNumber, int accountNumber, string ownersID, double overDraftLimit) : base(numOfBankAccounts, numOfBranchNumber, accountNumber, ownersID)
        {
            this.OverDraftLimit = overDraftLimit;
        }

        public CheckingAccount(int numOfBankAccounts, int numOfBranchNumber, int accountNumber, string ownersID) : this(numOfBankAccounts, numOfBranchNumber, accountNumber, ownersID, DefaultOverDraftLimit)
        {
        }

        public double GetOverDraftLimit()
        {
            return OverDraftLimit;
        }

        public void SetOverDraftLimit(double newOverDraftLimit)
        {
            this.OverDraftLimit = newOverDraftLimit;
        }

        public override bool Withdrawal(object o)
        {
            double amount = (double)o;

            if (amount <= 0 || AccountBalance - amount < -OverDraftLimit)
            {
                return false;
            }

            AccountBalance -= amount;
            return true;
        }

        public override bool AtRisk()
        {
            if (AccountBalance < 0)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return base.ToString() +
                   "\nOverdraft limit: " + OverDraftLimit;
        }

        public static void UnitTest()
        {
            CheckingAccount account1 = new CheckingAccount(1, 123, 456789, "ID123", 1000);

            Console.WriteLine("GetOverDraftLimit: " + (account1.GetOverDraftLimit() == 1000));
            Console.WriteLine("Initial AtRisk: " + (account1.AtRisk() == false));

            Console.WriteLine("Deposit 500: " + (account1.Deposit(500) == true));
            Console.WriteLine("Balance after deposit: " + (account1.GetAccountBalance() == 500));

            Console.WriteLine("Withdrawal 1200: " + (account1.Withdrawal(1200.0) == true));
            Console.WriteLine("Balance after withdrawal: " + (account1.GetAccountBalance() == -700));
            Console.WriteLine("AtRisk after withdrawal: " + (account1.AtRisk() == true));

            Console.WriteLine("Withdrawal over limit: " + (account1.Withdrawal(301.0) == false));
            Console.WriteLine("Withdrawal zero: " + (account1.Withdrawal(0.0) == false));
            Console.WriteLine("Withdrawal negative: " + (account1.Withdrawal(-100.0) == false));
            Console.WriteLine("Balance unchanged: " + (account1.GetAccountBalance() == -700));

            account1.SetOverDraftLimit(800);

            Console.WriteLine("SetOverDraftLimit: " + (account1.GetOverDraftLimit() == 800));
            Console.WriteLine("Withdrawal to exact limit: " + (account1.Withdrawal(100.0) == true));
            Console.WriteLine("Balance at limit: " + (account1.GetAccountBalance() == -800));
            Console.WriteLine("Withdrawal beyond limit: " + (account1.Withdrawal(1.0) == false));
            Console.WriteLine("ToString: " + account1.ToString().Contains("Overdraft limit: 800"));

            CheckingAccount account2 = new CheckingAccount(2, 456, 987654, "ID456");

            Console.WriteLine("Default overdraft: " + (account2.GetOverDraftLimit() == 500));
            Console.WriteLine("Default withdrawal: " + (account2.Withdrawal(500.0) == true));
            Console.WriteLine("Default over limit: " + (account2.Withdrawal(1.0) == false));
            Console.WriteLine("Default AtRisk: " + (account2.AtRisk() == true));
        }
    }
}
