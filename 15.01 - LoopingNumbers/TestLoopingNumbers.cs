using System;

namespace _15._01___LoopingNumbers
{
        
    class TestLoopingNumbers
    {
        static void Main()
        {
            PositiveEvenNumber evenlist = new PositiveEvenNumber(20);            
            evenlist.ToString();

            PrimeNumber primelist = new PrimeNumber(20);

            Console.WriteLine(primelist);
           
            Console.ReadLine();
        }
    }
}
