using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinSolution.Collection
{
    class Q6
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            int tak = 0;
            while (true)
            {
                Console.WriteLine("Enter your name : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your percentage : ");
                double percentage = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter branch you choose : ");
                string branch = Console.ReadLine();

                Console.WriteLine("Enter your city name : ");
                string city = Console.ReadLine();

                ht.Add(new Addmission(name, percentage, branch), city);
                tak++;
                if (tak == 2)
                {
                    Console.WriteLine("Do you want to add more : ");
                    string str = Console.ReadLine();
                    if (str.Length == 2)
                        break;
                    tak = 0;
                }
            }

            foreach (DictionaryEntry obj in ht)
                Console.WriteLine(obj.Key + "==>" + obj.Value);
        }
    }

    class Addmission
    {
        string StudName;
        double StudPercentage;
        string branch;

        public Addmission(string studName, double studPercentage, string branch)
        {
            StudName1 = studName;
            StudPercentage1 = studPercentage;
            this.Branch = branch;
        }

        public string StudName1 { get => StudName; set => StudName = value; }
        public double StudPercentage1 { get => StudPercentage; set => StudPercentage = value; }
        public string Branch { get => branch; set => branch = value; }

        public override bool Equals(object? obj)
        {
            return obj is Addmission addmission &&
               StudName == addmission.StudName &&
               StudPercentage == addmission.StudPercentage &&
               branch == addmission.branch;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(StudName, StudPercentage, branch);
        }

        public override string ToString()
        {
            return " Student name : " + StudName + " Student percentage : " + StudPercentage + " Student required branch : " + Branch;
        }
    }
}
