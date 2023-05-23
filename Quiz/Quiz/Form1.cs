using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{ 
    public partial class quiz : Form
    {
        public quiz()
        {
            InitializeComponent();
        }

        public string[] questions = { "Are you Better?", "Have you heard of BetterCompass?", "Is Haydn Better?", "Is Dutt Better?", "Is Visual Studio good?"};
        public string[] answers = { "no", "Yes" , "no" , "no" , "no"};
        public int score = 0;
        public int question = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtQuestion.Text= questions[0];
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (btnCheck.Text == "Check" && txtAnswer.Text == answers[questions.findIndex(txtQuestion.Text)])
            {
                txtRes.Text = "Better";
                btnCheck.Text = "Move on";
                score++;
                question++;
                txtScore.Text = "Score: " + score;
            }
            else if (btnCheck.Text == "Check")
            {
                question++;
                txtRes.Text = "Wurse";
                btnCheck.Text = "Move on";
            }
            else if (btnCheck.Text == "Move on")
            {
                if (question != questions.Length)
                {
                    btnCheck.Text = "Check";
                    txtQuestion.Text = questions[questions.findIndex(txtQuestion.Text) + 1];
                    txtRes.Text = "";
                }
                else
                {
                    float perc = (float)score / (float)questions.Length * 100;
                    txtRes.Text = "You got " + score + "/5 (" + perc + "%)";
                    btnCheck.Visible = false;
                    txtAnswer.Visible = false;  
                    txtQuestion.Visible = false;
                    txtScore.Visible = false;
                }
            }
        }
    }

    public static class Extensions
    {
        public static int findIndex<T>(this T[] array, T item)
        {
            return Array.FindIndex(array, val => val.Equals(item));
        }
    }
}
