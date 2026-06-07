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

        public override string ToString()
        {
            return base.ToString() +
                   "\nOverdraft limit: " + OverDraftLimit;
        }

        public static void UnitTest()
        {
            CheckingAccount checkingAccount1 = new CheckingAccount(1, 123, 456789, "ID123", 1000);
            Console.WriteLine(checkingAccount1);
            Console.WriteLine("Deposit 500: " + checkingAccount1.Deposit(500));
            Console.WriteLine("Withdraw 1200: " + checkingAccount1.Withdraw(1200));
            Console.WriteLine("Withdraw 300: " + checkingAccount1.Withdraw(300));
            Console.WriteLine(checkingAccount1);
        }
    }
}
