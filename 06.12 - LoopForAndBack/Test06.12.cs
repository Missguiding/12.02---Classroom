using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._12
{
    // goal of the exercise:

    // • Show in the console all numbers that are divisible by 3 and lowerthan 1000.
    // o All on the same line(if possible) with a comma and a spacebetween them.
    // Like this: 0, 3, 6, 9, 12, 15, 18, 21, … 993, 996, 999
    //Can you do it backwards? 999, 996, 993, …, 6, 3,

    class Program
    {
        static void Divisibleby3(int intANumber)  // method with parameter
        {
            if (intANumber % 3 == 0)              // if the number to check is divisible by 3 
            {
                Console.Write(intANumber + ", "); // write number with ,
                intANumber++;                     // increase number
            }
        }

        static void LoopNumbersForwards(int intYourNumber) // method to loop numbers forwards, parameter = max
        {
            for (int counter = 0; counter <= intYourNumber; counter++)
            {
                Divisibleby3(counter);                     // use method if the number is divisible by 3
            }
        }

        static void LoopNumbersBackwards(int intYourNumber) // method to loop numbers bachwards, parameter = max
        {
            for (int counter = intYourNumber; counter >= 0; counter--)
            {
                Divisibleby3(counter);                      // use method if the number is divisible by 3           
            }

        }
        static void Main()
        {
            LoopNumbersForwards(1000); // use method to loop numbers forwards until your max number
            Console.WriteLine();

            LoopNumbersBackwards(1000); // use method to loop numbers backwards from your max number
            Console.ReadLine();
        }
    }
}
