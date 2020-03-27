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

            ResetPrimeLabel();
        }


        private void SetPrimeLabelTrue()
        {
            isPrimeLabel.ForeColor = Color.LightGreen;
            isPrimeLabel.Text = "Maybe";
        }
        private void SetPrimeLabelFalse()
        {
            isPrimeLabel.ForeColor = Color.Red;
            isPrimeLabel.Text = "No";
        }
        private void ResetPrimeLabel()
        {
            isPrimeLabel.Text = "";
        }


        private void isPrimeButton_Click(object sender, EventArgs e)
        {
            BigInteger number;

            try
            {
                number = new BigInteger(firstNumberTextBox.Text);
            }
            catch (ArgumentException)
            {
                ResetPrimeLabel();
                return;
            }

            if (number.IsComposite())
                SetPrimeLabelFalse();
            else
                SetPrimeLabelTrue();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            BigInteger first;
            BigInteger second;

            try
            {
                first = new BigInteger(firstNumberTextBox.Text);
                second = new BigInteger(secondNumberTextBox.Text);
            }
            catch (ArgumentException)
            {
                resultTextBox.Text = "";
                return;
            }

            resultTextBox.Text = (first + second).ToString();
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            BigInteger first;
            BigInteger second;

            try
            {
                first = new BigInteger(firstNumberTextBox.Text);
                second = new BigInteger(secondNumberTextBox.Text);
            }
            catch (ArgumentException)
            {
                resultTextBox.Text = "";
                return;
            }

            resultTextBox.Text = (first - second).ToString();
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            BigInteger first;
            BigInteger second;

            try
            {
                first = new BigInteger(firstNumberTextBox.Text);
                second = new BigInteger(secondNumberTextBox.Text);
            }
            catch (ArgumentException)
            {
                resultTextBox.Text = "";
                return;
            }

            resultTextBox.Text = (first * second).ToString();
        }
    }
}
