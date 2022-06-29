using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution.Delegate
{
    class Demo2
    {
        static int add(int a,float b,long m)
        {
            Console.WriteLine("Add:"+(a+b));
            return (int)(a + b);
        }
        static void greet(string nm)
        {
            Console.WriteLine("Good afternoon,"+nm);
        }

        static  bool isEven(int a)
        {
            if (a % 2 == 0)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            Func<int, float, long, int> f1 = add;
            int ans = f1(10, 3.4f, 90l);
            Action<string> f2 = greet;

            f2("smita");
            Predicate<int> f3 = isEven;
            Console.WriteLine((f3(67)));
        }
    }
}
