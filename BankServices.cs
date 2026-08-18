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

        public static void UnitTest()
        {
            BankServices bank = new BankServices();

            Console.WriteLine("Constructor creates 100 places: " + (bank.GetAccounts().Length == 100));
            Console.WriteLine("First place is empty: " + (bank.GetAccounts()[0] == null));
            Console.WriteLine("RiskAccounts in empty bank: " + (bank.RiskAccounts().Length == 0));
            Console.WriteLine("GetOwnerWithMostMoney in empty bank: " + (bank.GetOwnerWithMostMoney() == ""));
            Console.WriteLine("GetAccountDetails for missing account: " + (bank.GetAccountDetails(999) == " "));
            Console.WriteLine("AccountPerPerson for missing account: " + (bank.AccountPerPerson(999) == 0));
            Console.WriteLine("GetAccountsByOwner for missing owner: " + (bank.GetAccountsByOwner("ID999") == null));

            BasicAccount account1 = new BasicAccount(1, 100, 101, "ID1");
            CheckingAccount account2 = new CheckingAccount(1, 100, 102, "ID1", 500);
            BasicAccount account3 = new BasicAccount(1, 100, 103, "ID2");
            SavingAccount account4 = new SavingAccount(1, 100, 104, "ID3", new Date(31, 12, 2026));
            CheckingAccount account5 = new CheckingAccount(1, 100, 105, "ID4", 500);

            Console.WriteLine("Deposit to account1: " + (account1.Deposit(1000) == true));
            Console.WriteLine("Deposit to account2: " + (account2.Deposit(500) == true));
            Console.WriteLine("Deposit to account3: " + (account3.Deposit(2000) == true));
            Console.WriteLine("Withdraw from account5: " + (account5.Withdraw(100) == true));
            Console.WriteLine("Add account1: " + (bank.AddAccount(account1) == true));
            Console.WriteLine("Add account2: " + (bank.AddAccount(account2) == true));
            Console.WriteLine("Add account3: " + (bank.AddAccount(account3) == true));
            Console.WriteLine("Add account4: " + (bank.AddAccount(account4) == true));
            Console.WriteLine("Add account5: " + (bank.AddAccount(account5) == true));
            Console.WriteLine("Account1 saved in first place: " + (bank.GetAccounts()[0] == account1));
            Console.WriteLine("GetAccountDetails existing account: " + bank.GetAccountDetails(101).Contains("Account number: 101"));
            Console.WriteLine("GetAccountDetails missing account: " + (bank.GetAccountDetails(999) == " "));
            Console.WriteLine("AccountPerPerson: " + (bank.AccountPerPerson(101) == 2));
            Console.WriteLine("AccountPerPerson missing account: " + (bank.AccountPerPerson(999) == 0));

            BasicAccount[] ownerAccounts = bank.GetAccountsByOwner("ID1");

            Console.WriteLine("GetAccountsByOwner is not null: " + (ownerAccounts != null));
            Console.WriteLine("GetAccountsByOwner length: " + (ownerAccounts.Length == 2));
            Console.WriteLine("First owner account: " + (ownerAccounts[0] == account1));
            Console.WriteLine("Second owner account: " + (ownerAccounts[1] == account2));
            Console.WriteLine("GetAccountsByOwner missing owner: " + (bank.GetAccountsByOwner("ID999") == null));
            Console.WriteLine("GetOwnerWithMostMoney: " + (bank.GetOwnerWithMostMoney() == "ID2"));

            BasicAccount[] riskAccounts = bank.RiskAccounts();

            Console.WriteLine("RiskAccounts length: " + (riskAccounts.Length == 2));
            Console.WriteLine("First risk account: " + (riskAccounts[0] == account4));
            Console.WriteLine("Second risk account: " + (riskAccounts[1] == account5));

            BankServices secondBank = new BankServices();
            BasicAccount[] newAccounts = new BasicAccount[] { account1, account2 };

            secondBank.SetAccounts(newAccounts);

            Console.WriteLine("SetAccounts length: " + (secondBank.GetAccounts().Length == 2));
            Console.WriteLine("SetAccounts first account: " + (secondBank.GetAccounts()[0] == account1));
            Console.WriteLine("SetAccounts second account: " + (secondBank.GetAccounts()[1] == account2));
            Console.WriteLine("AddAccount when array is full: " + (secondBank.AddAccount(account3) == false));
        }
    }
}
