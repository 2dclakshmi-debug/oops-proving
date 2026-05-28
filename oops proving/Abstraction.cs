using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class1
{
    abstract class College
    {
        public void start()
        {
            Console.WriteLine("College started");
        }
        public void run()
        {
            Console.WriteLine("College is running");
        }
        public abstract void stop();
    }
    class College1 : College
    {
        public override void stop()
        {
            Console.WriteLine("College is closed");
        }
    }
    internal class abstraction
    {
        //static void Main(string[] args)
        //{
        //    College c = new College1();
        //    c.start();
        //    c.run();
        //    c.stop();

        //    College1 ab = new College1();
        //    ab.start();
        //    ab.run();
        //    ab.stop();
        //}
    }



}
