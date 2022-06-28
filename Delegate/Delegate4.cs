using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution.Delegate
{
    public delegate void mydelegate123(int a, int b);
    class Delegate4
    {
        static void Main(string[] args)
        {
            mydelegate12 d1 = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            d1(10, 20);
            mydelegate123 d2 = (x, y) => Console.WriteLine(x + y);
            d2(10, 20);
        }
    }
    
}

