using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_proving
{
    class BankAccount
    {
        double balance;
        string Pin;
        public double Balance
        {
            get { return balance; }
            set { if(value>0) 
                balance = value; }
        }
        public void Deposit(double amount)
        {
            if(amount>0)
            {
                Balance += amount;
            }
        }
        public void withdraw(double amount,string enteredpin)
        {
            if(enteredpin==Pin && Balance>=amount)
            {
                Balance -= amount;
            }
        }
        public BankAccount(double initialbalance,string accountpin)
        {
            balance = initialbalance;
            Pin = accountpin;
        }
        internal class encapsulation3
        {
            //static void Main(string[] args)
            //{
            //    BankAccount bc = new BankAccount(10000, "1234");
            //    bc.Deposit(5000);
            //    bc.withdraw(2000, "1234");
            //    bc.withdraw(2000, "5667");
            //    Console.WriteLine("available balance :" + bc.balance);

            //}
        }
    }
}
