using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution.Exception
{
    class MultipalException
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string sr = null;
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(s[3]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine(sr.ToUpper());
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                Console.WriteLine("Division" + a / b);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
