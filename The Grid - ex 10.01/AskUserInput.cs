using System;

namespace The_Grid___ex_10._01
{
    public class AskUserInput
    {
        private int _intUsersInput;
        public AskUserInput()
        {

        }
        public int UsersInput
        {
            get
            {
                return _intUsersInput;
            }
        }

        static void Message(string strAQuestion)
        {
            Console.WriteLine("{0}", strAQuestion);
        }

        // ask userinput en ask startposition wijzigen naar een override method
        public int AskNumber(int intMinValue, int intMaxValue)
        {
            bool blnCorrectInput = true;
            string strAskNumber = "Enter a number between " + intMinValue + " and " + intMaxValue;
            string strErrorMessage = "You dit not give a correct number, please try again";


            while (blnCorrectInput)
            {
                Message(strAskNumber);

                try
                {
                    // input must be a number, no text or decimal
                    _intUsersInput = Convert.ToInt32(Console.ReadLine());

                    // check the input
                    if (_intUsersInput >= intMinValue && _intUsersInput <= intMaxValue)
                    {
                        blnCorrectInput = false;
                    }
                    // if the input is not correct, show your message
                    else
                    {
                        Message(strErrorMessage);
                    }
                }
                catch
                {
                    Message(strErrorMessage);
                }
            }

            return _intUsersInput;
        }
    }
}
