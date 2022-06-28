using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("ketaki", 23);
            ht.Add("Sonam", 60);
            ht.Add(23, "raj");

            // ht.Add(new Stud1(1, "priya"), "priya@gmail.com");
            Console.WriteLine(ht[23]);
            ht["sonam"] = 95;                          // replace 
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + "=>" + d.Value);
            }
            ht.Clear();
            foreach (var k in ht.Keys)
            {
                Console.WriteLine(k + " " + ht[k]);
            }
        }
    }
}
