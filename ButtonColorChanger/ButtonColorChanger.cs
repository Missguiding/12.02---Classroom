using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonColorChanger
{
    public partial class ChangeColor : Form
    {
        private int intCounterClicks;
        public ChangeColor()
        {
            InitializeComponent();
        }

        private void buttonChanger_Click(object sender, EventArgs e)
        {
            Random rdmColor = new Random();
            Color randomColor = Color.FromArgb(rdmColor.Next(255), rdmColor.Next(255), rdmColor.Next(255));

            this.buttonChanger.BackColor = randomColor;
            intCounterClicks++;
        }
               
                
        private void messageButton_Click(object sender, EventArgs e)
        {          
            
            MessageBox.Show("You changed " + intCounterClicks + " times the color");
        }
    }
}
