using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ReinSolution.Collection
{
    class PlayerQ4
    {
        int playerid;
        string name;
        string country;
        string team;

        public PlayerQ4(int playerid, string name, string country, string team)
        {
            this.Playerid = playerid;
            this.Name = name;
            this.Country = country;
            this.Team = team;

        }

        public int Playerid { get => playerid; set => playerid = value; }
        public string Name { get => name; set => name = value; }
        public string Country { get => country; set => country = value; }
        public string Team { get => team; set => team = value; }

        public override string ToString()
        {
            return "Player id : " + playerid + " Player Name : " + name + " Player Country : " + country + " Player team : " + team;
        }
    }

    internal class Q4
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();

            int tag = 0, counter = 0;
            while (true)
            {
                Console.WriteLine("How many player details you want to add : ");
                int add = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter player id : ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter player name : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter player country : ");
                string country = Console.ReadLine().ToUpper();

                Console.WriteLine("Enter player ipl team : ");
                string team = Console.ReadLine();

                al.Add(new PlayerQ4(id, name, country, team));
                tag++;

                if (tag == add)
                {
                    Console.WriteLine("Do you want to add more (yes/no):");
                    string str = Console.ReadLine();

                    if (str.Length == 2)
                        break;
                    tag = 0;
                }

            }
            Console.WriteLine("Player details are as follows : ");
            foreach (PlayerQ4 obj in al)
            {
                Console.WriteLine(obj);
            }
        }
    }
}

