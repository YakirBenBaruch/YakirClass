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

    }
}
