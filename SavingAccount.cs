
using System;

namespace Yakir
{
    public class SavingAccount : BasicAccount, IComparable
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

        public override bool Withdrawal(object o)
        {
            if (o == null)
                return false;

            object[] data = (object[])o;

            if (data.Length != 2)
                return false;

            double amount = (double)data[0];
            Date withdrawalDate = (Date)data[1];

            if (amount <= 0 || amount > AccountBalance)
                return false;

            if (withdrawalDate == null)
                return false;

            if (withdrawalDate.CompareTo(ExpiryDateOfSaving) < 0)
                return false;

            AccountBalance -= amount;
            return true;
        }

        public int CompareTo(object obj)
        {
            SavingAccount other = (SavingAccount)obj;

            return ExpiryDateOfSaving.CompareTo(other.ExpiryDateOfSaving);
        }

        public override bool AtRisk()
        {
            return AccountBalance == 0;
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
            Console.WriteLine("Deposit: " + (account.Deposit(1000) == true));
            Console.WriteLine("Balance: " + (account.GetAccountBalance() == 1000));
            Console.WriteLine("AtRisk after deposit: " + (account.AtRisk() == false));

            Console.WriteLine("Withdrawal before expiry: " + (account.Withdrawal(new object[] { 500.0, new Date(30, 12, 2024) }) == false));
            Console.WriteLine("Withdrawal zero: " + (account.Withdrawal(new object[] { 0.0, new Date(31, 12, 2024) }) == false));
            Console.WriteLine("Withdrawal negative: " + (account.Withdrawal(new object[] { -100.0, new Date(31, 12, 2024) }) == false));
            Console.WriteLine("Withdrawal over balance: " + (account.Withdrawal(new object[] { 1001.0, new Date(31, 12, 2024) }) == false));
            Console.WriteLine("Withdrawal null: " + (account.Withdrawal(null) == false));
            Console.WriteLine("Withdrawal invalid length: " + (account.Withdrawal(new object[] { 100.0 }) == false));
            Console.WriteLine("Withdrawal null date: " + (account.Withdrawal(new object[] { 100.0, null }) == false));

            Console.WriteLine("Withdrawal on expiry: " + (account.Withdrawal(new object[] { 500.0, new Date(31, 12, 2024) }) == true));
            Console.WriteLine("Balance after withdrawal: " + (account.GetAccountBalance() == 500));

            SavingAccount later = new SavingAccount(2, 123, 456790, "ID456", new Date(31, 12, 2025));
            SavingAccount same = new SavingAccount(3, 123, 456791, "ID789", new Date(31, 12, 2024));

            Console.WriteLine("CompareTo earlier: " + (account.CompareTo(later) < 0));
            Console.WriteLine("CompareTo later: " + (later.CompareTo(account) > 0));
            Console.WriteLine("CompareTo equal: " + (account.CompareTo(same) == 0));

            account.SetExpiryDateOfSaving(new Date(31, 12, 2025));

            Console.WriteLine("Withdrawal before new expiry: " + (account.Withdrawal(new object[] { 500.0, new Date(1, 1, 2025) }) == false));
            Console.WriteLine("Withdrawal on new expiry: " + (account.Withdrawal(new object[] { 500.0, new Date(31, 12, 2025) }) == true));
            Console.WriteLine("Final balance: " + (account.GetAccountBalance() == 0));
            Console.WriteLine("Final AtRisk: " + (account.AtRisk() == true));
            Console.WriteLine("ToString: " + account.ToString().Contains("Expiry date of saving:"));
        }
    }
}
