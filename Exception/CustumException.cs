using System;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution.Exception
{
    class CustumException : ApplicationException
    {
        public CustumException(string msg) : base(msg)
        {

        }
    }
    class User
    {
        string nm;
        long mobile;
        string password;
        public void accept()
        {
            Console.WriteLine("Enter mobile number,name,Passs");
            nm = Console.ReadLine();
            mobile = long.Parse(Console.ReadLine());
            password = Console.ReadLine();
            validate();

        }
        void validate()
        {
            if (password.Length < 8)
            {
                throw new CustumException("Password size should br greater than 8");
            }

        }
    }
    class Demo
    {
        static void Main(string[] args)
        {
            User u = new User();

            while (true)
            {
                try
                {
                    u.accept();
                    break;
                }
                catch (CustumException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Console.WriteLine("Main ends");
        }

    }
}
