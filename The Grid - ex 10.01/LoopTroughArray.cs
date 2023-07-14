using System;

namespace The_Grid___ex_10._01
{

    
    public class LoopThroughArray
    {
        public void ReadArray(int[,] intGird) // method with array parameter
        {
            for (int rowNumber = 0; rowNumber < intGird.GetLength(0); rowNumber++) // loop trough row length
            {
                for (int colNumber = 0; colNumber < intGird.GetLength(1); colNumber++) // loop trough colomn length
                {
                    Console.Write(intGird[rowNumber, colNumber]); // show row and colomn on console
                    Console.Write('\t'); // put a space between numbers
                }
                Console.Write('\n'); 
            }
        }
    }
}


