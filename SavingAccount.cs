
using System;

namespace Yakir
{
    public class SavingAccount : BasicAccount, IComparable
    {
        private Date ExpiryDateOfSaving;

        public SavingAccount(int numOfBankAccounts,
            int numOfBranchNumber, int accountNumber,
            string ownersID, Date expiryDateOfSaving)
            : base(numOfBankAccounts, numOfBranchNumber,
                   accountNumber, ownersID)
        {
            this.ExpiryDateOfSaving = new Date(expiryDateOfSaving);
        }

        public void SetExpiryDateOfSaving(Date expiryDateOfSaving)
        {
            this.ExpiryDateOfSaving = new Date(expiryDateOfSaving);
        }

        public bool Withdrawal(double amount, Date withdrawalDate)
        {
            if (amount > 0 &&
                amount <= AccountBalance &&
                withdrawalDate != null &&
                withdrawalDate.CompareTo(ExpiryDateOfSaving) >= 0)
            {
                AccountBalance -= amount;
                return true;
            }

            return false;
        }

        public override bool Withdrawal(object o)
        {
            if (!(o is Tuple<double, Date>))
            {
                return false;
            }

            Tuple<double, Date> data = (Tuple<double, Date>)o;

            return Withdrawal(data.Item1, data.Item2);
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }

            if (!(obj is SavingAccount))
            {
                throw new ArgumentException("Object must be SavingAccount");
            }

            SavingAccount other = (SavingAccount)obj;

            return this.ExpiryDateOfSaving.CompareTo(
                other.ExpiryDateOfSaving);
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
    }
}
