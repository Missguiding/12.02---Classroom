using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForms
{
    public partial class Calculator : Form
    {
        double _dblValue = 0; // we can use decimals to calculate
        string _strOperation = ""; // store the result 
        bool _blnOperationPressed = false; // start with false

        public Calculator()
        {
            InitializeComponent();
        }

        // for all the buttons the same action
        private void BtnNumber_Click(object sender, EventArgs e)
        {
            // remove the fist 0 on the screen or if there was a operation pressed
            if ((TxbResultScreen.Text == "0") || (_blnOperationPressed))
            {
                TxbResultScreen.Clear(); // clear result screen
            }
            
            _blnOperationPressed = false;
            // cast through object sender because we use the function for all button numbers
            Button _buttonInput = (Button)sender;

            if (_buttonInput.Text == ".")
            {
                // if it doesn't contains a decimal point
                if(!TxbResultScreen.Text.Contains("."))
                {
                    // put everyting that is on the screen togehter.
                    TxbResultScreen.Text = TxbResultScreen.Text + _buttonInput.Text;
                }

            }
            else
            {
                // show in the result screen the 
                TxbResultScreen.Text = TxbResultScreen.Text + _buttonInput.Text;
            }
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            // if you press CE button, put screen on 0
            TxbResultScreen.Text = "0";
        }

        private void TxbResultScreen_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOperator_Click(object sender, EventArgs e)
        {
            // cast through object sender because we use the function for all operators
            Button _btnOperatorClick = (Button)sender;

            // store whatever was pressed
            _strOperation = _btnOperatorClick.Text;
            // number that was given on the screen store into double (convert first)
            _dblValue = Double.Parse(TxbResultScreen.Text);
            // put bool on true to do further actions
            _blnOperationPressed = true; // 
            lblEquation.Text = _dblValue + " " + _strOperation;

        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
           
            lblEquation.Text = "";
            switch (_strOperation)
            {
                case "+":
                    // show on screen
                    // the stored value + the current value on the screen
                    TxbResultScreen.Text = (_dblValue + double.Parse(TxbResultScreen.Text)).ToString();
                    break;
                case "-":
                    // show on screen
                    // the stored value - the current value on the screen
                    TxbResultScreen.Text = (_dblValue - double.Parse(TxbResultScreen.Text)).ToString();
                    break;
                case "/":
                    // show on screen
                    // the stored value / the current value on the screen
                    TxbResultScreen.Text = (_dblValue / double.Parse(TxbResultScreen.Text)).ToString();
                    break;
                case "*":
                    // show on screen
                    // the stored value * the current value on the screen
                    TxbResultScreen.Text = (_dblValue * double.Parse(TxbResultScreen.Text)).ToString();
                    break;

                default:
                    break;                   

            }// end switch
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // erase text screen
            TxbResultScreen.Text = "0";
            // value back on 0
            _dblValue = 0;
        }
    }
}
