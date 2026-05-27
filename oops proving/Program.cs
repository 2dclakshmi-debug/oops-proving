using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_proving
{
    public class Counter
    {
        private int instanceCount = 0;
        private static int staticcount = 0;


        public void increment()
        {
            int localCount = 0;
            instanceCount++;
            staticcount++;
            localCount++;
            Console.WriteLine("instance count :" + instanceCount);
            Console.WriteLine("static count :" + staticcount);
            Console.WriteLine("local count :"+localCount);
            
        }
    }
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Counter counter1 = new Counter();
        //    Counter counter2=new Counter();
        //    Counter counter3= new Counter(); 

        //    Console.WriteLine("counter :1");
        //    counter1.increment();
        //    counter1.increment();
        //    Console.WriteLine("counter :2");
        //    counter2.increment();
        //    counter2.increment();
        //    Console.WriteLine("counter :3");
        //    counter3.increment();
        //    counter3.increment();

        //}
    }
}
