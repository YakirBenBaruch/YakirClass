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

        public SavingAccount(int numOfBankAccounts, int numOfBranchNumber, int accountNumber, string ownersID, Date expiryDateOfSaving)
            : base(numOfBankAccounts, numOfBranchNumber, accountNumber, ownersID)
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
    }
}