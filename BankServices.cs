using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class BankServices
    {
        private BasicAccount[] Accounts;

        public BasicAccount[] GetAccounts()
        {
            return Accounts;
        }

        public void SetAccounts(BasicAccount[] accounts)
        {
            this.Accounts = accounts;
        }

        public BankServices()
        {
            this.Accounts = new BasicAccount[100];
        }

        public bool AddAccount(BasicAccount account)
        {
            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] == null)
                {
                    Accounts[i] = account;
                    return true;
                }
            }
            return false;
        }

        public string GetAccountDetails(int accountNumber)
        {
            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i].GetAccountNumber() == accountNumber)
                {
                    return Accounts[i].ToString();
                }
            }

            return " ";
        }

        public int AccountPerPerson(int accountNumber)
        {
            string OwnerID = "";

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i].GetAccountNumber() == accountNumber)
                {
                    OwnerID = Accounts[i].GetOwnersID();
                }
            }

            int count = 0;

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i].GetOwnersID() == OwnerID)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
