using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinSolution.Collection
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            int nav = 0;
            while(true)
            {
                Console.WriteLine("Enter your favourite color:");
                string name = Console.ReadLine();
                al.Add(name);
                nav++;

                if(nav==4)
                {
                    Console.WriteLine("do you  want to add more:(yes/no)");

                    string str = Console.ReadLine();
                    if(str.Length==2)
                        break;
                        nav = 0;
                }
                Console.WriteLine("ArrayList before sorting");
                foreach(string str1 in al)
                    Console.WriteLine(str1);

                Console.WriteLine("ArrayList after sorting:");
                for(var i=al.Count-1;i>=0;i--)
                {
                    Console.WriteLine(al[i]);
                }
            }
        }
    }
}
