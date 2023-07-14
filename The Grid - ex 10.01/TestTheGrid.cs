using System;

namespace The_Grid___ex_10._01
{
    partial class TestTheGrid
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



        // klasse maken voor the rules
        // the loop

        // maak een try catch voor als je tijdens de loop geblokkerd wordt
        public class LoopTroughArray
        {
            public void ReadArray(int[,] intGird)
            {
                foreach (int number in intGird)
                {
                    Console.WriteLine(number + '\t');
                    if (number == 0)
                    {
                        Console.WriteLine('\t');
                    }
                   // Console.WriteLine('\n');
                }
                //for (int horizantal = 0; horizantal < intGird.Length - 1; horizantal++)
                //{
                //    for (int vertical = 0; vertical < intGird.Length - 1; vertical++)
                //    {
                //        Console.WriteLine(intGird[horizantal, vertical]);
                //        Console.WriteLine('\t');
                //    }
                //    Console.WriteLine('\n');
                //}
            }


            static void Main()
            {
                // ask users input 
                AskUserInput giveNumber = new AskUserInput();
                // with the metod in AskUserInput and min and max number you get the number you want
                giveNumber.AskNumber(4, 10);

                // make a grid based on the given number of the user.
                int[,] intYourGrid = new int[giveNumber.UsersInput, giveNumber.UsersInput];

                // ask where the fist nummer must be 
                AskStartPosition defineStartPosition = new AskStartPosition();
                // define position horizontal
                int intPositionHorizontal = defineStartPosition.AskPosition(giveNumber.UsersInput);
                // define position vertical
                int intPositionVertical = defineStartPosition.AskPosition(giveNumber.UsersInput);
                // based on the given numbers you can put number one on the grid
                intYourGrid[intPositionHorizontal, intPositionVertical] = 1;


                LoopTroughArray YourGrid = new LoopTroughArray();
                // show grid
                YourGrid.ReadArray(intYourGrid);


                //Console.WriteLine();
                Console.ReadLine();

                // clean up your code - using? 
            }
        }
    }
}
