using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution.Delegate
{
    public delegate void mydelegate(int x, int y);
    public delegate void mydel2(string n);
     internal class MulticastDelegate
    {
            static void add(int a, int b)
            {
                Console.WriteLine("sum=" + (a + b));
            }
            static void mult(int a, int b)
            {
                Console.WriteLine("product=" + (a * b));
            }
            void greet(string nm)
            {
                Console.WriteLine("WELCOME " + nm);
            }
            static void Main(string[] args)
            {
            //callback
            //declare
            //Delegates====a variable which holds the refernce of a  function
            //single cast deligates
            MulticastDelegate ob = new MulticastDelegate();
                mydel2 d2 = ob.greet;
                //multicast delegates
                mydelegate d1 = MulticastDelegate.mult;
                d1 += add;
                //d1.Invoke(10,20);
                //d2.Invoke("PRASHANT");
                d1(10, 20);
                d2("SMITA");
            }
        }
    }
}