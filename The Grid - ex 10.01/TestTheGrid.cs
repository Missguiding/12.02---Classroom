using System;

namespace The_Grid___ex_10._01
{
    // You have an array and the array has 2 dimensions.
    // You ask through the console a starting position. Meaning, in what column and what row you place the number 1.
    // Add checks if it is possible.
    //  o E.g.Going to row 15 and column 8 is not possible.
    //  o Re-ask until you got a correct location.
    // Let’s assume that you want the number 1 in row 1 and column 1.
    // The next number, 2 can be placed at different locations.
    //  • These are the rules.
    //   o You can only place a number in a location if there is nonumber yet.
    //   o When you go horizontal, you jump over 2 cells.
    //   o When you go vertical, you jump over 2 cells.
    //   o When you go diagonal, you jump over 1 cell.
    // You have to try the direction where you can place the next number, 
    //in a specific order.         

    partial class TestTheGrid
    {
        static void Main()
        {
           
            AskUserInput giveNumber = new AskUserInput(); // ask users input            
            giveNumber.AskNumber(4, 10); // with the metod in AskUserInput and min and max number you get the number you want
           
            int[,] intYourGrid = new int[giveNumber.UsersInput, giveNumber.UsersInput]; // make a grid based on the given number of the user.
           
            AskStartPosition defineStartPosition = new AskStartPosition(); // ask where the fist nummer must be            
            int intPositionHorizontal = defineStartPosition.AskPosition(giveNumber.UsersInput);// define position horizontal           
            int intPositionVertical = defineStartPosition.AskPosition(giveNumber.UsersInput); // define position vertical
           
            intYourGrid[intPositionHorizontal, intPositionVertical] = 1; // based on the given numbers you can put number one on the grid

            LoopThroughArray YourGrid = new LoopThroughArray();            
            YourGrid.ReadArray(intYourGrid);// show grid



            //Console.WriteLine();
            Console.ReadLine();


            // clean up your code - using?               
        }
    }
}
