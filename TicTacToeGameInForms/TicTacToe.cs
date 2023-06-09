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
        bool blnTurn = true; // true = X turn; false = Y turn 
        int intTurnCount = 0; // als er 9 zijn is het gelijk spel
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Lindsey", "Tic Tac Toe About");
        }       

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            Form InsertNames = new Form();
            InsertNames.ShowDialog();
        }

        private void button_click(object sender, EventArgs e) // alle knoppen hebben zelfde event(property: click - button_click)
        {
            // telkens we op een knop duwen, kijken wie zijn beurt het is, wisselen van spelen, knop onbruikbaarzetten en checken of er een winnaar is

            Button _button = (Button)sender; //  object sender casten naar button en opslaan in _button

            if (blnTurn) // als button wordt gedrukt willen we weten wie zijn beurt het is adhv blnTurn weten we of het X of Y beurt is
            {
                _button.Text = "X"; // speler X (true) speelt met X"
            }
            else
            {
                _button.Text = "O"; // speler Y (false) speelt met "O"
            }
            blnTurn = !blnTurn; // true is false en zal op de volgende speler worden gezet

            _button.Enabled = false; // enable(bool) _button om ervoor te zorgen dat gezette waarde niet kan wijzigen.

            intTurnCount++; // elke keer een button is geclicked, tel één bij

            checkForWinner();
        }

        private void checkForWinner() // methode om winnaar te checken
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
                    _strWinner = "O";
                    lblOWinCount.Text = (Convert.ToInt32(lblOWinCount.Text) + 1).ToString(); // lblOWinCount is string waarde
                    // telt de keren O wint
                }
                else
                {
                    _strWinner = "X";
                    lblXWinCount.Text = (Int32.Parse(lblXWinCount.Text) + 1).ToString();  // telt de keren X wint
                }


                MessageBox.Show(_strWinner + " Wins!", "Yay!");
            } // end if
            else
            {
                if (intTurnCount == 9) // als de teller op 9 staat is er geen winnaar
                {
                    lblDrawCount.Text = (Convert.ToInt32(lblDrawCount.Text) + 1).ToString(); // telt de keren gelijk spel
                    MessageBox.Show("Draw!", "Bummer!");
                }
            } // end else if

        } // end method checkForWinner

        private void disableButtons()
        {
            try
            {
                foreach (Control input in Controls) // voor iedere button op formulier, maak onbruikbaar (1 keer X of O)
                {
                    Button _button = (Button)input;
                    _button.Enabled = false; //enable(bool) _button om ervoor te zorgen dat gezette waarde niet kan wijzigen.
                }// end foreach
            } //end try

            catch
            {
                // er moet niks opgevangen worden
            }

        } // end method disableButtons

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            blnTurn = true;
            intTurnCount = 0;

            foreach (Control input in Controls) // voor iedere button op formulier, maak onbruikbaar (1 keer X of O)
            {
                try
                {
                    Button _button = (Button)input;
                    _button.Enabled = true; //enable(bool) _button om ervoor te zorgen dat gezette waarde niet kan wijzigen.
                    _button.Text = "";
                }
                catch
                {
                    // er moet niks opgevangen worden
                }
            } // end foreach

        }

        private void button_enter(object sender, EventArgs e)
        {
            Button _button = (Button)sender; //  object sender casten naar button en opslaan in _button

            if (_button.Enabled) // toets ingeschakeld
            {
                if (blnTurn)
                {
                    _button.Text = "X";
                }
                else
                {
                    _button.Text = "O";
                }
            } // end if
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button _button = (Button)sender; //  object sender casten naar button en opslaan in _button

            if (_button.Enabled) // toets ingeschakeld
            {
                _button.Text = ""; // zet tekst op blanco
            } // end if

        }

        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetWinCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblXWinCount.Text = "0";
            lblOWinCount.Text = "0";
            lblDrawCount.Text = "0";
        }
    }
}
