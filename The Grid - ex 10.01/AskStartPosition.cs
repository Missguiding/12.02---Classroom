using System;

namespace The_Grid___ex_10._01
{
    partial class TestTheGrid
    {
        public class AskStartPosition
        {

            private int _intUsersChoise;
            public AskStartPosition()
            {

            }
            public int UsersChoise
            {
                get
                {
                    return _intUsersChoise;
                }
            }

            static void Message(string strAQuestion)
            {
                Console.WriteLine("{0}", strAQuestion);
            }
            // ask userinput en ask startposition wijzigen naar een override method
            public int AskPosition(int intMaxNumber)
            {
                bool blnCorrectInput = true;
                string strAskNumber = "Enter a number between " + 1 + " and " + intMaxNumber;
                string strErrorMessage = "You dit not give a correct number, please try again";


                while (blnCorrectInput)
                {
                    Message(strAskNumber);
                    try
                    {
                        _intUsersChoise = Convert.ToInt32(Console.ReadLine());

                        if (_intUsersChoise > 1 && _intUsersChoise < intMaxNumber)
                        {
                            blnCorrectInput = false;
                        }
                        Message(strErrorMessage);
                    }
                    catch
                    {
                        Message(strErrorMessage);
                    }
                }
                return _intUsersChoise;
            }
        }
    }
}
