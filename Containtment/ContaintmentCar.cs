using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOps
{
    class Engine
    {
        string ename;
        public Engine (string name)
        {
            this.ename = ename ;
        }
        public void show()
        {
            Console.WriteLine("it is a petrol car"+ename);
        }

    }
    class ContaintmentCar
    {
         int id;
         string name;
         int price;
        Engine eng;

        public ContaintmentCar(int id,string name,int price,Engine eng)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.eng = eng;
        }
        void display()
        {
            Console.WriteLine(id+" "+name+" "+price+" ");
            eng.show();
        }
        static void Main(string[] args)
        {
            Engine e = new Engine("Petrol");
            ContaintmentCar c = new ContaintmentCar(10345, "swift", 6000000,e);
            c.display();
        }
    }
}
