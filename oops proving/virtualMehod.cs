using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_proving
{
    class Concrete
    {
        public void Display()
        {
            Console.WriteLine("Display method is calling");
        }
        public virtual void Show()
        {
            Console.WriteLine("Show method is calling");
        }
    }
    internal class virtualMehod:Concrete
    {
        public void message()
        {
            Console.WriteLine("Message method is calling");
        }
        public override void Show()
        {
            Console.WriteLine("show method overriden here");
        }
    }
    internal class Abc
    {
        //static void Main(string[] args)
        //{
        //    Concrete concrete = new Concrete();
        //    concrete.Show();
        //    concrete.Display();
        //    virtualMehod vm=new virtualMehod();
        //    vm.message();
        //    vm.Show();
        //}
    }
}
