using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_proving
{
    abstract class Power
    {
        public void PBillGenrate()
        {
            Console.WriteLine("Normal Power BillGenerating");
        }
        public abstract void GenerateBill();
    }
    class Homeutilities:Power
    {
        public override void GenerateBill() 
        {
            Console.WriteLine("Enter consumed units:");
            double units=Convert.ToDouble(Console.ReadLine());
            double bill = units * 5;
            Console.WriteLine("Home power bill : " + bill);
        }
        class Agriculture : Power
        {
            public override void GenerateBill()
            {
                Console.WriteLine("Enter consumed units:");
                double units = Convert.ToDouble(Console.ReadLine());
                double bill = units * 0;
                Console.WriteLine("Agriculture power bill : " + bill);
            }
        }
        class Companies : Power
        {
            public override void GenerateBill()
            {
                Console.WriteLine("Enter consumed units:");
                double units = Convert.ToDouble(Console.ReadLine());
                double bill = units * 10;
                Console.WriteLine("Company power bill : "+bill);
            }
        }
        internal class ElectricityBill
        {
            //static void Main(string[] args)
            //{
            //    Power p = new Homeutilities();
            //    p.PBillGenrate();
            //    p.GenerateBill();
            //    p = new Agriculture();
            //    p.GenerateBill();
            //    p = new Companies();
            //    p.GenerateBill();

            //}
        }

    }
}
