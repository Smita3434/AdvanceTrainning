using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution.Delegate
{
    public delegate void del1(int a, int b);
    class MultiDemo
    {
        static void add(int a,int b)
        {
            Console.WriteLine("sum:"+(a+b));
        }

        static void sub(int a, int b)
        {
            Console.WriteLine("sub:" + (a - b));
        }

        static void mul(int a, int b)
        {
            Console.WriteLine("mul:" + (a * b));
        }
        static void div(int a, int b)
        {
            Console.WriteLine("div:" + (a / b));
        }
        static void Main(string[] args)
        {

            del1 d1 = delegate (int a, int b)
              {
                  Console.WriteLine("Anonyomous method" + (a + b));
              };
            d1(10, 2);

            // lambda expre

            del1 d2 = (p, q) => Console.WriteLine("lambda"+(p+q));
            d2 +=  (x, y)=>Console.WriteLine("lambda22"+(x*y));
            d2(8, 4);

            /*del1 d1 = add;
            d1 = d1 + mul;
                d1 = d1 + sub;

            d1(10, 3);
            d1 = d1 - sub;
            d1(9, 9);*/
        }
    }
}
