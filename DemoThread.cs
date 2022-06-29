using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ReinSolution
{
    class DemoThread
    {
        public void m1()
        {
            for(int i=1;i<=10;i++)
            
                Console.WriteLine(i+Thread.CurrentThread.Name);
                Thread.Sleep(1000);
            
        }
        static void Main(string[] args)
        {
            DemoThread ob = new DemoThread();
            Console.WriteLine("Hello world");
            Console.WriteLine("good evening");
            Thread t1 = new Thread(ob.m1);
            Thread t2 = new Thread(ob.m1);

            t1.Name = "Smita";
            t2.Name = "Saavi";

            t1.Start();
            t2.Start();
        }
    }
}
