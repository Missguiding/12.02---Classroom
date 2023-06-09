using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15._01___LoopingNumbers
{
    public class PrimeNumber
    {
        private readonly List<ushort> _lstPrimeNumbers;

        public PrimeNumber(ushort ushtMaxNumber)
        {
             //= ushtMaxNumber;
            _lstPrimeNumbers = new List<ushort>();
        }
        static bool[] PrimeArray(ulong Input) // method array bool + one parameter
        {
            bool[] blnTrueArray = new bool[Input + 1]; // make bool array - length is asked number - make the size + 1

            for (int aCounter = 0; aCounter < blnTrueArray.Length; aCounter++) // loop 
            {
                blnTrueArray[aCounter] = true; // make all values true
            }

            return blnTrueArray; // return filled array
        }
        static void FindPrimeNumbers(bool[] blntrueArray) // method array bool + one parameter
        {
            blntrueArray[0] = false; // make element 0 false
            blntrueArray[1] = false; // make element 1 false

            for (int aCounter = 0; aCounter < blntrueArray.Length; aCounter++)// repeat for next element
            {
                if (blntrueArray[aCounter]) // find next element that is true with a loop

                {
                    //all numbers that are a multiplication of 2 or the current counter, become false (only when they are true)
                    for (int secondCounter = aCounter + aCounter; secondCounter < blntrueArray.Length; secondCounter += aCounter)
                    {
                        blntrueArray[secondCounter] = false;
                    }
                }
            }
        }
    }
}
