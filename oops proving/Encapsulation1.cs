using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace oops_proving
{
    class account
    {
        private double Balance;
        private static int Pin = 1234;
        public void saving(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("saving amount is :" + amount);
            }
        }
        public void withdral()
        {
            Console.WriteLine("Enter your pin ");
            int pin = int.Parse(Console.ReadLine());
            if (pin == 1234)
            {
                Console.WriteLine("Enter withdrawl amount : ");
                double amount = double.Parse(Console.ReadLine());

                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine("withdraw amount is :" + amount);
                }
            }
            else
            {
                Console.WriteLine("Please enter valid pin");
            }
        }
        public double getBalance()
        {
            return Balance;
        }
        internal class Encapsulation1
        {
            static void Main(string[] args)
            {
                account accc = new account();
                accc.saving(5000);
                accc.withdral();
                Console.WriteLine("Available balance :" + accc.getBalance());
            }
        }
    }
}
