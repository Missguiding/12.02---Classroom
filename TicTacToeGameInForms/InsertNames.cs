using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeGameForms
{
    public partial class InsertNames : Form
    {
        public InsertNames()
        {
            InitializeComponent();
        }

        private void InsertNames_Load(object sender, EventArgs e)
        {

        }

        private void XbPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxbPlayer2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r") // if press enter on player 2
            {
                btnPlayGame.PerformClick(); // activate play button
            }
        }
        private void BtnPlayGame_Click(object sender, EventArgs e)
        {
            // if you click on play button, put tru method the name in the game           
            TicTacToe.SetPlayerNames(txbPlayer1.Text, txbPlayer2.Text) ;            
            this.Close(); // closes current form
        }
    }
}
