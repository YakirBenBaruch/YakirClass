using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class SavingAccount : BasicAccount
    {
        private Date ExpiryDateOfSaving;

        public SavingAccount(int numOfBankAccounts, int numOfBranchNumber, int accountNumber, string ownersID, Date expiryDateOfSaving) : base(numOfBankAccounts, numOfBranchNumber, accountNumber, ownersID)

        {
            this.ExpiryDateOfSaving = new Date(expiryDateOfSaving);
        }

        public void SetExpiryDateOfSaving(Date expiryDateOfSaving)
        {
            this.ExpiryDateOfSaving = new Date(expiryDateOfSaving);
        }

        public bool Withdrawal(double amount, Date withdrawalDate)
        {
            if (amount > 0 && amount <= AccountBalance && withdrawalDate.CompareTo(ExpiryDateOfSaving) >= 0)
            {
                AccountBalance -= amount;
                return true;
            }

            return false;
        }

        public override bool AtRisk()
        {
            if (this.AccountBalance == 0)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() +
                   "\nExpiry date of saving: " + ExpiryDateOfSaving;
        }

        public static void UnitTest()
        {
            SavingAccount account = new SavingAccount(1, 123, 456789, "ID123", new Date(31, 12, 2024));

            Console.WriteLine("Initial AtRisk: " + (account.AtRisk() == true));
            Console.WriteLine("Deposit 1000: " + (account.Deposit(1000) == true));
            Console.WriteLine("Balance after deposit: " + (account.GetAccountBalance() == 1000));
            Console.WriteLine("AtRisk after deposit: " + (account.AtRisk() == false));
            Console.WriteLine("Withdrawal before expiry date: " + (account.Withdrawal(500, new Date(30, 12, 2024)) == false));
            Console.WriteLine("Balance after failed withdrawal: " + (account.GetAccountBalance() == 1000));
            Console.WriteLine("Withdrawal zero: " + (account.Withdrawal(0, new Date(31, 12, 2024)) == false));
            Console.WriteLine("Withdrawal negative amount: " + (account.Withdrawal(-100, new Date(31, 12, 2024)) == false));
            Console.WriteLine("Withdrawal over balance: " + (account.Withdrawal(1001, new Date(31, 12, 2024)) == false));
            Console.WriteLine("Withdrawal on expiry date: " + (account.Withdrawal(500, new Date(31, 12, 2024)) == true));
            Console.WriteLine("Balance after withdrawal: " + (account.GetAccountBalance() == 500));

            account.SetExpiryDateOfSaving(new Date(31, 12, 2025));

            Console.WriteLine("Withdrawal before new expiry date: " + (account.Withdrawal(500, new Date(1, 1, 2025)) == false));
            Console.WriteLine("Withdrawal on new expiry date: " + (account.Withdrawal(500, new Date(31, 12, 2025)) == true));
            Console.WriteLine("Final balance: " + (account.GetAccountBalance() == 0));
            Console.WriteLine("Final AtRisk: " + (account.AtRisk() == true));
            Console.WriteLine(account);
        }
    }
}