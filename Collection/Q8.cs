using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution.Collection
{
    class Q8
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("pune");
            al.Add("Mumbai");
            al.Add("Nasik");
            al.Add("pune");

            Hashtable ht = new Hashtable();

            Console.WriteLine("Elements of ArrayList : ");
            foreach (dynamic obj in al)
            {
                Console.WriteLine(obj);
            }


            foreach (dynamic data in al)
            {
                if (ht.ContainsKey(data))
                {
                    int value = (int)ht[data];
                    ht[data] = value + 1;
                }
                else
                {
                    ht.Add(data, 1);
                }
            }


            Console.WriteLine("Elements of hashtable : ");
            foreach (DictionaryEntry obj in ht)
            {
                Console.WriteLine(obj.Key + "==>" + obj.Value);
            }
        }
    }
}

