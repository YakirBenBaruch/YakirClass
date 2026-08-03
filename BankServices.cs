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

        public BasicAccount[] GetAccountsByOwner(string ownerID)
        {
            int count = 0;

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i].GetOwnersID() == ownerID)
                {
                    count++;
                }
            }

            if (count == 0)
            {
                return null;
            }

            BasicAccount[] ownerAccounts = new BasicAccount[count];
            int index = 0;

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i].GetOwnersID() == ownerID)
                {
                    ownerAccounts[index] = Accounts[i];
                    index++;
                }
            }

            return ownerAccounts;
        }

        public string GetOwnerWithMostMoney()
        {
            string maxOwnerID = "";
            double maxMoney = 0;

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null)
                {
                    string ownerID = Accounts[i].GetOwnersID();
                    double totalMoney = 0;

                    for (int j = 0; j < Accounts.Length; j++)
                    {
                        if (Accounts[j] != null && Accounts[j].GetOwnersID() == ownerID)
                        {
                            totalMoney += Accounts[j].GetAccountBalance();
                        }
                    }

                    if (totalMoney > maxMoney)
                    {
                        maxMoney = totalMoney;
                        maxOwnerID = ownerID;
                    }
                }
            }

            return maxOwnerID;
        }

        public BasicAccount[] RiskAccounts()
        {
            int count = 0;

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i].AtRisk() == true)
                {
                    count++;
                }
            }

            BasicAccount[] risksAccounts = new BasicAccount[count];

            int index = 0;

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i].AtRisk() == true)
                {
                    risksAccounts[index] = Accounts[i];
                    index++;
                }
            }

            return risksAccounts;
        }
    }
}
