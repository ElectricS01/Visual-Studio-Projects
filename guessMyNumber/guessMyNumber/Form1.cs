using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessMyNumber
{
    public partial class guessMyNumber : Form
    {
        public int number;
        public int change;
        public guessMyNumber()
        {
            InitializeComponent();
        }

        public void generate()
        {
            Random rand = new Random();
            number = rand.Next(0, 100);
        }

        private void guessMyNumber_Load(object sender, EventArgs e)
        {
            generate();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            if (change > 5)
            {
                txtNumber.Text = "";
                System.Threading.Thread.Sleep(500);
                generate();
                txtRes.Text = "Too many guesses, Number regenerated";
                change = 0;
                txtGuess.Text = change.ToString();
            }
            if (txtNumber.Text != "" && int.Parse(txtNumber.Text) < 7)
                {
                if (number > int.Parse(txtNumber.Text))
                {
                    txtRes.Text = "Too low";
                    change++;
                    txtGuess.Text = change.ToString();
                }
                else if (number < int.Parse(txtNumber.Text))
                {
                    txtRes.Text = "Too high";
                    change++;
                    txtGuess.Text = change.ToString();
                }
                else if (number == int.Parse(txtNumber.Text))
                {
                    txtRes.Text = "Correct";
                }
                
            }
        }
    }
}
