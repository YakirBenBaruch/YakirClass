
using System;

namespace Yakir
{
    public class BankServices
    {
        private BasicAccount[] Accounts;

        public BankServices()
        {
            this.Accounts = new BasicAccount[100];
        }

        public BasicAccount[] GetAccounts()
        {
            return Accounts;
        }

        public void SetAccounts(BasicAccount[] accounts)
        {
            this.Accounts = accounts;
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
            string ownerID = "";

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i].GetAccountNumber() == accountNumber)
                {
                    ownerID = Accounts[i].GetOwnersID();
                }
            }

            int count = 0;

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i].GetOwnersID() == ownerID)
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

        public Node<BusinessAccount> GetBusinessByWealthValue()
        {
            Node<BusinessAccount> head = null;

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i] is BusinessAccount)
                {
                    BusinessAccount account = (BusinessAccount)Accounts[i];
                    Node<BusinessAccount> newNode = new Node<BusinessAccount>(account);

                    if (head == null || account.CompareTo(head.GetValue()) > 0)
                    {
                        newNode.SetNext(head);
                        head = newNode;
                    }
                    else
                    {
                        Node<BusinessAccount> temp = head;

                        while (temp.GetNext() != null && account.CompareTo(temp.GetNext().GetValue()) <= 0)
                        {
                            temp = temp.GetNext();
                        }

                        newNode.SetNext(temp.GetNext());
                        temp.SetNext(newNode);
                    }
                }
            }

            return head;
        }

        public Node<SavingAccount> GetSavingByDueDate()
        {
            Node<SavingAccount> head = null;

            for (int i = 0; i < Accounts.Length; i++)
            {
                if (Accounts[i] != null && Accounts[i] is SavingAccount)
                {
                    SavingAccount account = (SavingAccount)Accounts[i];
                    Node<SavingAccount> newNode = new Node<SavingAccount>(account);

                    if (head == null || account.CompareTo(head.GetValue()) < 0)
                    {
                        newNode.SetNext(head);
                        head = newNode;
                    }
                    else
                    {
                        Node<SavingAccount> temp = head;

                        while (temp.GetNext() != null && account.CompareTo(temp.GetNext().GetValue()) >= 0)
                        {
                            temp = temp.GetNext();
                        }

                        newNode.SetNext(temp.GetNext());
                        temp.SetNext(newNode);
                    }
                }
            }

            return head;
        }

        public static void UnitTest()
        {
            BankServices bank = new BankServices();

            Console.WriteLine("Constructor size: " + (bank.GetAccounts().Length == 100));
            Console.WriteLine("First account is null: " + (bank.GetAccounts()[0] == null));
            Console.WriteLine("Empty RiskAccounts: " + (bank.RiskAccounts().Length == 0));
            Console.WriteLine("Empty business list: " + (bank.GetBusinessByWealthValue() == null));
            Console.WriteLine("Empty saving list: " + (bank.GetSavingByDueDate() == null));

            BusinessAccount business1 = new BusinessAccount(1, 100, 101, "ID1", "Business1", 1000, 0);
            BusinessAccount business2 = new BusinessAccount(1, 100, 102, "ID1", "Business2", 2000, 0);
            SavingAccount saving1 = new SavingAccount(1, 100, 103, "ID2", new Date(1, 1, 2027));
            SavingAccount saving2 = new SavingAccount(1, 100, 104, "ID3", new Date(1, 1, 2025));
            CheckingAccount checking = new CheckingAccount(1, 100, 105, "ID4", 500);

            business1.Deposit(300);
            business2.Deposit(500);
            saving1.Deposit(100);
            checking.Withdrawal(100.0);

            Console.WriteLine("Add business1: " + (bank.AddAccount(business1) == true));
            Console.WriteLine("Add business2: " + (bank.AddAccount(business2) == true));
            Console.WriteLine("Add saving1: " + (bank.AddAccount(saving1) == true));
            Console.WriteLine("Add saving2: " + (bank.AddAccount(saving2) == true));
            Console.WriteLine("Add checking: " + (bank.AddAccount(checking) == true));

            Console.WriteLine("GetAccounts: " + (bank.GetAccounts()[0] == business1));

            Console.WriteLine("GetAccountDetails: " + bank.GetAccountDetails(101).Contains("Account number: 101"));
            Console.WriteLine("Missing account details: " + (bank.GetAccountDetails(999) == " "));

            Console.WriteLine("AccountPerPerson: " + (bank.AccountPerPerson(101) == 2));
            Console.WriteLine("Missing AccountPerPerson: " + (bank.AccountPerPerson(999) == 0));

            BasicAccount[] ownerAccounts = bank.GetAccountsByOwner("ID1");

            Console.WriteLine("GetAccountsByOwner length: " + (ownerAccounts.Length == 2));
            Console.WriteLine("First owner account: " + (ownerAccounts[0] == business1));
            Console.WriteLine("Second owner account: " + (ownerAccounts[1] == business2));
            Console.WriteLine("Missing owner: " + (bank.GetAccountsByOwner("UNKNOWN") == null));

            Console.WriteLine("GetOwnerWithMostMoney: " + (bank.GetOwnerWithMostMoney() == "ID1"));

            BasicAccount[] risks = bank.RiskAccounts();

            Console.WriteLine("RiskAccounts count: " + (risks.Length == 2));
            Console.WriteLine("First risk account: " + (risks[0] == saving2));
            Console.WriteLine("Second risk account: " + (risks[1] == checking));

            Node<BusinessAccount> businesses = bank.GetBusinessByWealthValue();

            Console.WriteLine("Richest business first: " + (businesses.GetValue() == business2));
            Console.WriteLine("Second business: " + (businesses.GetNext().GetValue() == business1));
            Console.WriteLine("End of business list: " + (businesses.GetNext().GetNext() == null));

            Node<SavingAccount> savings = bank.GetSavingByDueDate();

            Console.WriteLine("Earliest saving first: " + (savings.GetValue() == saving2));
            Console.WriteLine("Second saving: " + (savings.GetNext().GetValue() == saving1));
            Console.WriteLine("End of saving list: " + (savings.GetNext().GetNext() == null));

            BankServices secondBank = new BankServices();
            BasicAccount[] newAccounts = { business1, business2 };

            secondBank.SetAccounts(newAccounts);

            Console.WriteLine("SetAccounts length: " + (secondBank.GetAccounts().Length == 2));
            Console.WriteLine("SetAccounts first: " + (secondBank.GetAccounts()[0] == business1));
            Console.WriteLine("SetAccounts second: " + (secondBank.GetAccounts()[1] == business2));
            Console.WriteLine("AddAccount when full: " + (secondBank.AddAccount(saving1) == false));
        }
    }
}
