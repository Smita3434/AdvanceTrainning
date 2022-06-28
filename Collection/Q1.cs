using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinSolution.Collection
{
    internal class Q1
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("sun");
            al.Add("mon");
            al.Add("sat");
            al.Add("sun");
            al.Add("mon");
            al.Add("sat");
            al.Add("sun");
            al.Add("sat");
            al.Add("sun");
            al.Add("mon");

            Console.WriteLine("ArrayList before removing duplicates:");
            foreach(var item in al)
                Console.WriteLine(item);

            Console.WriteLine("ArrayList after removing duplicates:");
            for(int i=0;i<al.Count;i++)
            {
                for(int j=i+1;j<al.Count;j++)
                {
                    if(al[i].Equals(al[j]))
                    {
                        al.Remove(al[i]);
                    }
                }
            }
            foreach(var obj in al)
                Console.WriteLine(obj);

        }
    }
}
