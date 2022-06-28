using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ReinSolution.Collection
{
   internal  class Q5
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            int tag = 0;
            Console.WriteLine("How many cities do you want to add : ");
            int add = int.Parse(Console.ReadLine());
            while (true)
            {

                Console.WriteLine("Enter pincode : ");
                long pincode = long.Parse(Console.ReadLine());

                Console.WriteLine("Enter city name : ");
                string city = Console.ReadLine();

                Console.WriteLine("Enter state : ");
                string state = Console.ReadLine();

                ht.Add(new Pincity(pincode, city), state);
                tag++;
                if (tag == add)
                {
                    Console.WriteLine("Do you want to add more (yes/no): ");
                    string str = Console.ReadLine();

                    if (str.Length == 2)
                        break;
                }
            }
            Console.WriteLine("List of cities with pincode is : ");
            foreach (DictionaryEntry obj in ht)
            {
                Console.WriteLine(obj.Key + "==>" + obj.Value);
            }
        }
    }
    class Pincity
    {
        long pincode;
        string city;

        public Pincity(long pincode, string city)
        {
            this.Pincode = pincode;
            this.City = city;
        }

        public long Pincode { get => pincode; set => pincode = value; }
        public string City { get => city; set => city = value; }

        public override bool Equals(object? obj)
        {
            return obj is Pincity pincity &&
                   pincode == pincity.pincode &&
                   city == pincity.city;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(pincode, city);
        }

        public override string ToString()
        {
            return " Pincode : " + pincode + " City name : " + city;
        }
    }
}
