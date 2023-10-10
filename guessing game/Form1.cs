using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace guessing_game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int secretnumber;

        public Form1()
        {
            InitializeComponent();
            secretnumber = random.Next(1, 101);
            
        }

        private void numberinput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Guessbutton_Click(object sender, EventArgs e)
        {
            int guess = Convert.ToInt32(numberinput.Text); ;
            
            if (guess == secretnumber)
            {
                outputlable.Text = $"You got it!!";
            }
            else if (guess > secretnumber)
            {
                outputlable.Text = $"Sorry too high :(";
            }
            else 
            {
                outputlable.Text = $"Sorry too low:(";
            }
        }
    }
}
