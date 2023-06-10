using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGameForms
{
    public partial class TicTacToe : Form
    {
        bool blnTurn = true; // true = X turn; false = Y turn.
        int intTurnCount = 0; 
        static string strPlayer1;
        static string strPlayer2;

        public TicTacToe()
        {
            InitializeComponent();
        }

        
        // method to set the players name in the game.
        public static void SetPlayerNames(string strName1, string strName2) 
        {
            strPlayer1 = strName1;
            strPlayer2 = strName2;
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Lindsey", "Tic Tac Toe About");
        }       

        // when loading game, first open insert names form.
        private void TicTacToe_Load(object sender, EventArgs e)
        {
            InsertNames PlayerNames = new InsertNames();
            PlayerNames.ShowDialog();
            lblXWin.Text = strPlayer1;
            lblOWin.Text = strPlayer2;
        }

        // all 9 buttons have same event(property: click - button_click).
        // every time we press a button, see who's turn it is, disable button, check if there is a winner.
        private void button_click(object sender, EventArgs e) 
        {           
           
            Button _button = (Button)sender; // casting object sender to button and store in _button.

            if (blnTurn) // if button is pressed  we want to know who's turn it is. using blnTurn we know if it is X or Y its turn.
            {
                _button.Text = "X"; // speler X (true) plays with X".
            }
            else
            {
                _button.Text = "O"; // speler Y (false) plays with "O".
            }
            blnTurn = !blnTurn; // true is false and wil change who's turn it is.

            _button.Enabled = false; // enable(bool) _button to make sure that value cannot change..

            intTurnCount++; // every time button is clicked, ad one.

            checkForWinner(); // use method to check if there is a winner.
        } // end if else

        private void checkForWinner() // method to check if there is a winner.
        {
            bool blnThereIsAWinner = false;

            //horizontale checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
            {
                blnThereIsAWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                blnThereIsAWinner = true;
            }

            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                blnThereIsAWinner = true;
            }

            //vertical checks
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                blnThereIsAWinner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                blnThereIsAWinner = true;
            }

            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                blnThereIsAWinner = true;
            }

            //diagonal checks
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                blnThereIsAWinner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
            {
                blnThereIsAWinner = true;
            } // end nesting

            if (blnThereIsAWinner)
            {
                disableButtons();

                string _strWinner = "";

                if (blnTurn)
                {
                    _strWinner = strPlayer2;
                    // counts times player 2 wins
                    lblOWinCount.Text = (Convert.ToInt32(lblOWinCount.Text) + 1).ToString(); // lblOWinCount is string value.
                    ResetGame();
                }
                else
                {
                    _strWinner = strPlayer1;
                    // count times player 1 wins
                    lblXWinCount.Text = (Int32.Parse(lblXWinCount.Text) + 1).ToString();
                    ResetGame();
                }

                MessageBox.Show(_strWinner + " Wins!", "Yay!");
            } // end if else
            else
            {
                if (intTurnCount == 9) // when 9 time played, there is no winner.
                {
                    lblDrawCount.Text = (Convert.ToInt32(lblDrawCount.Text) + 1).ToString(); // counts times draw.
                    MessageBox.Show("Draw!", "Bummer!");
                    ResetGame();
                }
            } // end if else

        } // end method checkForWinner

        private void disableButtons()
        {
            try
            {
                foreach (Control input in Controls) // for every button on formuler, make unusable (1 time X or O).
                {
                    Button _button = (Button)input;
                    _button.Enabled = false; //enable(bool) _button to make sure that value cannot change.
                }// end foreach
            } //end try

            catch
            {
                // nothing to catch
            }

        } // end method disableButtons

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ResetGame()
        {
            foreach (Control input in Controls) // for every button on formuler, make unusable (1 time X or O).
            {
                try
                {
                    Button _button = (Button)input;
                    _button.Enabled = true; //enable(bool) _button to make sure that value cannot change.
                    _button.Text = "";
                }
                catch
                {
                    // nothing to catch
                }
            } // end fore

        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame(); // use method to reset the game            
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button _button = (Button)sender; //  cast object sender to button and store in _button.

            if (_button.Enabled) // empower button
            {
                if (blnTurn)
                {
                    _button.Text = "X";
                }
                else
                {
                    _button.Text = "O";
                }
            } // end if else
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button _button = (Button)sender; // cast object sender to button and store in _button.

            if (_button.Enabled) // empower button.
            {
                _button.Text = ""; // put text on blanc.
            } // end if

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // reset, set on "0" the score counts
        private void resetWinCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblXWinCount.Text = "0";
            lblOWinCount.Text = "0";
            lblDrawCount.Text = "0";
        }

        private void lblXWin_Click(object sender, EventArgs e)
        {

        }

        private void lblOWin_Click(object sender, EventArgs e)
        {

        }

       
    }
}
