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

        public override string ToString()
        {
            return base.ToString() +
                   "\nExpiry date of saving: " + ExpiryDateOfSaving;
        }

        public static void UnitTest()
        {
            SavingAccount savingAccount1 = new SavingAccount(1, 123, 456789, "ID123", new Date(31, 12, 2024));
            Console.WriteLine(savingAccount1);
            Console.WriteLine("Deposit 1000: " + savingAccount1.Deposit(1000));
            Console.WriteLine("Withdraw 500 on 30/12/2024: " + savingAccount1.Withdrawal(500, new Date(30, 12, 2024)));
            Console.WriteLine("Withdraw 500 on 31/12/2024: " + savingAccount1.Withdrawal(500, new Date(31, 12, 2024)));
            Console.WriteLine(savingAccount1);
        }
    }
}