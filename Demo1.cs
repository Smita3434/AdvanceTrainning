using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution.Delegate
{
    public delegate int del2(int a, int b);
    class Demo1
    {
        static int add1(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            del2 ob = (a, b) =>
              {
                  return a + b;
              };
            int r = ob(10, 20);
            Console.WriteLine(r);

            del2 ob1 = (a, b) => a + b;
            Console.WriteLine("Answer"+ob1(8,4));
        }
    }
}
