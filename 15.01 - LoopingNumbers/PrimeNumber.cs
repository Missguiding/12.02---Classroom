using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._01___LoopingNumbers
{
    public class PrimeNumber
    {
        private readonly List<ushort> lstPrimeNumbers;


        public PrimeNumber(ushort ushtMaxNumber)
        {
            lstPrimeNumbers = new List<ushort>();

            for (ushort counter = 2; counter <= ushtMaxNumber; counter++)
            {
                if (IsItAPrimeNumber(counter))
                {
                   ushort  ushtPrimeNumber = counter;
                    lstPrimeNumbers.Add(ushtPrimeNumber);
                }
            }
        }
        
        
        static bool IsItAPrimeNumber(int intNumberToCheck) // method to check if number is prime number

        {
            if(intNumberToCheck <2)
            {
                return false;
            }
            if (intNumberToCheck == 2)
            {
                return true;
            }
            if(intNumberToCheck %2 == 0)
            {
                return false;
            }

            return true;
        }



      
        public override string ToString()
        {
            Console.WriteLine("List with prime numbers:");
            foreach (ushort number in lstPrimeNumbers)
            {
                Console.WriteLine(number.ToString());
            }
            return lstPrimeNumbers.ToString();
        }
    }
}
