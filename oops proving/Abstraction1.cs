using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_proving
{
   abstract class HMWBS
    {
        public void billgenerate()
        {
            Console.WriteLine(" Normal Bill is generated");
        }
        public abstract void GenerateBill(double units);
    }
    class ResidentialCustomers:HMWBS
    {
        public override void GenerateBill(double units)
        {
            double bill = units * 5;
            Console.WriteLine("ResidentialCustomers bill: " + bill);
        }
    }
    class CommertialCustomers : HMWBS
    {
        public override void GenerateBill(double units)
        {
            double bill = units * 10;
            Console.WriteLine("CommertialCustomers bill: " + bill);
        }
    }
    class AgricultureCustomers : HMWBS
    {
        public override void GenerateBill(double units)
        {
            double bill = units * 0;
            Console.WriteLine("AgriCultureCustomers bill: " + bill);
        }
    }
    class IndustryCustomers : HMWBS
    {
        public override void GenerateBill(double units)
        {
            double bill = units * 15;
            Console.WriteLine("IndustryCustomers bill: " + bill);
        }
    }
    internal class Abstraction1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter consumed units");
            double unit = Convert.ToDouble(Console.ReadLine());
            HMWBS obj = new ResidentialCustomers();
            obj.billgenerate();
            obj.GenerateBill(unit);
            obj = new AgricultureCustomers();
            obj.GenerateBill(unit);
            obj = new IndustryCustomers();
            obj.GenerateBill(unit);
            obj = new CommertialCustomers();
            obj.GenerateBill(unit);


        }
    }
}
