namespace Year_12_Mentor_Swap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (float.TryParse(name12.Text, out _) || float.TryParse(name7.Text, out _))
            {
                line1.Visible = true;
                line2.Visible = false;
                line1.Text = "Names can't be numbers";
            }
            else if (name7.Text != "" && name12.Text != "")
            {
                line1.Visible = true;
                line2.Visible = true;
                line1.Text = "Year 7 student: " + name7.Text;
                line2.Text = "Mentor: " + name12.Text;
            }
            else
            {
                line1.Visible = false;
                line2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float o;
            if (!float.TryParse(sessions.Text, out o))
            {
                line1.Visible = false;
                line2.Visible = false;
            }
            else
            {
                line1.Visible = true;
                line2.Visible = false;
                line1.Text = "Sessions attended: " + (o * 20).ToString();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (float.TryParse(name12.Text, out _) || float.TryParse(altName.Text, out _))
            {
                line1.Visible = true;
                line2.Visible = false;
                line1.Text = "Names can't be numbers";
            }
            else if(name7.Text != "" && name12.Text != "")
            {
                line1.Visible = true;
                line2.Visible = true;
                line1.Text = "Year 7 student: " + name12.Text;
                line2.Text = "Mentor: " + name7.Text;
            }
            else
            {
                line1.Visible = false;
                line2.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (float.TryParse(name12.Text, out _) || float.TryParse(altName.Text, out _))
            {
                line1.Visible = true;
                line2.Visible = false;
                line1.Text = "Names can't be numbers";
            }
            else if (name12.Text != "" && altName.Text != "")
            {
                line1.Visible = false;
                line2.Visible = false;
                (name12.Text, altName.Text) = (altName.Text, name12.Text);
            }
            else
            {
                line1.Visible = false;
                line2.Visible = false;
            }
        }
    }
}
