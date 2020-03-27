using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigInteger
{
    public partial class BigIntegerCalculator : Form
    {
        public BigIntegerCalculator()
        {
            InitializeComponent();

            isPrimeLabel.Text = "";
        }


        private void isPrimeButton_Click(object sender, EventArgs e)
        {
            //Temp
            if ("Yes" == isPrimeLabel.Text)
            {
                isPrimeLabel.ForeColor = Color.Red;
                isPrimeLabel.Text = "No";
            }
            else
            {
                isPrimeLabel.ForeColor = Color.Green;
                isPrimeLabel.Text = "Yes";
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void subtractButton_Click(object sender, EventArgs e)
        {

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {

        }
    }
}
