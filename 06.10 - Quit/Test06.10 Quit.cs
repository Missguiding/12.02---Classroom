using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._10
{
    // goal of the exercise:

    // Ask for texts.
    //o As long as the text is not “quit”.
    //o Continue asking texts.
    //• The moment you have typed “quit”.
    //o Show all the entered texts, every text on a new line in the console.

    class Program
    {
        // method : ask for texts
        static void AskText()
        {
            bool blnWrongText = true;
            List<string> yourinput = new List<string>(); // create a list to store al the text

            Console.WriteLine("Search the escape word ... "); // ask the question

            while (blnWrongText) // while the answer is not correct
            {
                string strText = (Console.ReadLine()); // store the input in variable
                yourinput.Add(strText); // add the input to the list
                Console.Clear(); // clear the console
                Console.WriteLine("Try again"); // ask the user to try again

                if (strText == "quit") // when the word is correct
                {
                    Console.Clear();
                    Console.WriteLine("Correct!"); // says that the word is correct
                    Console.WriteLine("These were your attemps:");
                    ShowGivenText(yourinput); // use method to show all users input
                    blnWrongText = false; // stop the loop
                }
            }
        }
        // method to convert the list into text
        static void ShowGivenText(List<string> strText)
        {
            foreach (string item in strText)
            {
                Console.WriteLine(item);
            }
        }

        static void Main()
        {
            AskText();       // start game by using method.    
        }
    }
}

