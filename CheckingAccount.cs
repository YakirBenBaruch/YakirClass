using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void SetOverDraftLimit(double newOverDraftLimit)
        {
            this.OverDraftLimit = newOverDraftLimit;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0 || this.AccountBalance - amount < -this.OverDraftLimit)
            {
                return false;
            }

            this.AccountBalance -= amount;
            return true;
        }

        public override bool AtRisk()
        {
            if (this.AccountBalance < 0)
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

            Console.WriteLine("Initial AtRisk: " + (account1.AtRisk() == false));
            Console.WriteLine("Deposit 500: " + (account1.Deposit(500) == true));
            Console.WriteLine("Balance after deposit: " + (account1.GetAccountBalance() == 500));
            Console.WriteLine("Withdraw 1200: " + (account1.Withdraw(1200) == true));
            Console.WriteLine("Balance after withdrawal: " + (account1.GetAccountBalance() == -700));
            Console.WriteLine("AtRisk after withdrawal: " + (account1.AtRisk() == true));
            Console.WriteLine("Withdraw over limit: " + (account1.Withdraw(301) == false));
            Console.WriteLine("Balance after failed withdrawal: " + (account1.GetAccountBalance() == -700));
            Console.WriteLine("Withdraw zero: " + (account1.Withdraw(0) == false));
            Console.WriteLine("Withdraw negative amount: " + (account1.Withdraw(-100) == false));

            account1.SetOverDraftLimit(800);

            Console.WriteLine("Withdraw after changing limit: " + (account1.Withdraw(100) == true));
            Console.WriteLine("Balance at overdraft limit: " + (account1.GetAccountBalance() == -800));

            CheckingAccount account2 = new CheckingAccount(2, 456, 987654, "ID456");

            Console.WriteLine("Default limit withdrawal: " + (account2.Withdraw(500) == true));
            Console.WriteLine("Withdraw over default limit: " + (account2.Withdraw(1) == false));
            Console.WriteLine("Default account AtRisk: " + (account2.AtRisk() == true));
            Console.WriteLine(account1);
            Console.WriteLine(account2);
        }
    }
}
