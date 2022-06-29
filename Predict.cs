using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution.Delegate
{
    class Predict
    {
        static void filter(List<int> lst,Predicate<int>p1)
        {
            foreach(int element in lst)
            {
                bool b = p1(element);
                if(b==true)
                    Console.WriteLine(element);
            }
        }
        static bool iseven(int a)
        {
            return a % 2 == 0;
        }
        static void Main(string[] args)
        {
            List<int> l1 = new List<int> { 23, 45, 67, 88, 90, 2, 4 };
            /*
             List<int>l2=new List<int>();
            foreach(int d in l1)
            {
                if(d%2==0)
                    l2.Add(d);
            }
             */
            //callback Function
            List<int> l3 = l1.FindAll((a) => a % 2 == 0);
        }
    }
}
