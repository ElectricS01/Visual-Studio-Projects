using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Array
{
    public partial class carArray : Form
    {
        public carArray()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstCars.Items.Clear();
            string[] cars = { txtCar1.Text, txtCar2.Text, txtCar3.Text, txtCar4.Text, txtCar5.Text, txtCar6.Text };
            for (int i = 0; i < cars.Length; i++)
            {
                lstCars.Items.Add(cars[i]);
            }
            
        }
    }
}
