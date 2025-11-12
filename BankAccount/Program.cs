using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }
        public BankAccount(string accNo, string name, decimal bal)
        {
            AccountNumber = accNo;
            AccountHolder = name;
            Balance = bal;
        }
        public static BankAccount operator +(BankAccount a1, BankAccount a2)
        {
            return new BankAccount("Merged", "Combined Account", a1.Balance + a2.Balance);
        }
        public static BankAccount operator -(BankAccount acc, decimal amount)
        {
            if (amount > acc.Balance)
            {
                Console.WriteLine("Transaction failed: Insufficient Balance!");
                return acc;
            }
            return new BankAccount(acc.AccountNumber, acc.AccountHolder, acc.Balance - amount);
        }
        public static bool operator ==(BankAccount a1, BankAccount a2)
        {
            return a1.Balance == a2.Balance;
        }
        public static bool operator !=(BankAccount a1, BankAccount a2)
        {
            return a1.Balance != a2.Balance;
        }
        public static bool operator >(BankAccount a1, BankAccount a2)
        {
            return a1.Balance > a2.Balance;
        }
        public static bool operator <(BankAccount a1, BankAccount a2)
        {
            return a1.Balance < a2.Balance;
        }
        public override string ToString()
        {
            return $"Account Holder: {AccountHolder}, Account Number: {AccountNumber}, Balance: Rs.{Balance}";
        }
        public override bool Equals(object obj)
        {
            BankAccount acc = obj as BankAccount;
            return this.Balance == acc.Balance;
        }

        public override int GetHashCode()
        {
            return Balance.GetHashCode();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount("AC101", "Ramesh Kumar", 25000);
            BankAccount acc2 = new BankAccount("AC102", "Suresh Nair", 40000);

            Console.WriteLine(acc1);
            Console.WriteLine(acc2);

            // Merging using +
            BankAccount merged = acc1 + acc2;
            Console.WriteLine("\nMerging Accounts (using +):");
            Console.WriteLine("Combined Balance: " + merged.Balance);

            // Comparison
            Console.WriteLine("\nComparing balances:");
            Console.WriteLine($"AC101 < AC102 -> {acc1 < acc2}");
            Console.WriteLine($"AC101 == AC102 -> {acc1 == acc2}");

            // Withdrawal using -
            Console.WriteLine("\nWithdrawal Operation (using -):");
            BankAccount updatedAcc1 = acc1 - 5000;
            Console.WriteLine("New Balance of Ramesh: " + updatedAcc1.Balance);
        }
    }
}
