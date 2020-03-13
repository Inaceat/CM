using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace CaesarCypher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void decodeButton_Click(object sender, System.EventArgs e)
        {
            var russianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            plainTextBox.Text = CaesarShift(cypherTextBox.Text, (int) keyNumericUpDown.Value, russianAlphabet);
        }

        private string CaesarShift(string text, int shift, string alphabet)
        {
            var result = new StringBuilder(text.Length);

            foreach (var symbol in text)
            {
                var symbolIndex = alphabet.IndexOf(char.ToLower(symbol));

                if (-1 == symbolIndex)
                    result.Append(symbol);
                else
                    result.Append(alphabet[(symbolIndex + shift) % alphabet.Length]);
            }


            return result.ToString();
        }

        private void keyNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decodeButton_Click(null, null);
        }
    }
}
