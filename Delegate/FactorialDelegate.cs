using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ReinSolution.Delegate
{
    internal class FactorialDelegate
    {
        private delegate void result();
        private static void Main(string[] args)
        {
            System.Func<long, long> Fact = delegate(long Input)
            {
                if (Input == 1) return 1;
                long Output = 1;

                for (int indexer = 2; indexer <= Input; indexer++)
                Output = Output * indexer;

                return Output;
            };
            Console.WriteLine(Fact(5));
            Console.WriteLine(  );
        }   
    }
            
}
