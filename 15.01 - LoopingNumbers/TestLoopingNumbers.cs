using System;

namespace _15._01___LoopingNumbers
{
        
    class TestLoopingNumbers
    {
        static void Main()
        {
            PositiveEvenNumber evenlist = new PositiveEvenNumber(55);            
            evenlist.ToString();
            

            PrimeNumber primelist = new PrimeNumber(55);
            primelist.ToString();
            

            Console.WriteLine();
           
            Console.ReadLine();
        }
    }
}
