using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_proving
{
    class Accounts
    {
        private double balance;
        public void saving(double amount)
        {
            if(amount> 0)
            {
                balance+= amount;
                Console.WriteLine("saving amount is :"+amount);
            }
        }
        public void withdral(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine("withdraw amount is :" + amount);
            }
        }
        public double getBalance()
        {
            return balance;
        }
    }
    internal class Encapsulation
    {
        //static void Main(string[] args)
        //{
        //    Accounts acc=new Accounts();
        //    acc.saving(5000);
        //    acc.withdral(1000);
        //    Console.WriteLine("Available balance :"+acc.getBalance());
        //}
    
    }
}
