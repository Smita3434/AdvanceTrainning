using System;
using System.Collections.Generic;
using System.Text;

namespace Revision
{

    class Order
    {
        int id;
        int date;
        Customer customer;
        Item item;

        public Order(int id,int date)
        {
            this.id = id;
            this.date = date;
        }
        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public int Date
        {
            set { date = value; }
            get { return date; }
        }
    }
    class Customer
    {
        string customer;
        string cut_add;
        long mno;
    }
    class Item
    {

    }
    class Engine
    {
        string ename;
        public Engine(string name)
        {
            this.ename = ename;
        }
        public void show()
        {
            Console.WriteLine("it is a petrol car" + ename);
        }

    }
    class ContaintmentCar
    {
        int id;
        string name;
        int price;
        Engine eng;

        public ContaintmentCar(int id, string name, int price, Engine eng)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.eng = eng;
        }
        void display()
        {
            Console.WriteLine(id + " " + name + " " + price + " ");
            eng.show();
        }
        static void Main(string[] args)
        {
            Engine e = new Engine("Petrol");
            ContaintmentCar c = new ContaintmentCar(10345, "swift", 6000000, e);
            c.display();
        }
    }
    class pen
    {
        string brand;
        int cost;
        string color;

        public pen(string Brand,int Cost,string Color)
        {
            this.brand = Brand;
            this.cost = Cost;
            this.color = Color;
        }
        public void write()
        {

        }
        public string Brand { get => brand; set => brand = value; }
        public int Cost { get => cost; set => cost = value; }
        public string Color { get => color; set => color = value; }

    }
    class CompassBox
    {
        string compass_brand;
        int price;
        pen pen;
        static void Main(string[] args)
        {
            CompassBox box = new CompassBox();
            box.compass_brand = "apsaras";
            box.price = 250;
            box.pen = new pen("Trimax", 50, "black");
            box.pen.write();
        }

    }
}
