using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VigenereCipher
{
    public partial class MainForm : Form
    {
        private const string RussianAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public MainForm()
        {
            InitializeComponent();
        }

        private void decodeButton_Click(object sender, EventArgs e)
        {
            plainTextBox.Text = DecodeViginere(cipherTextBox.Text, keyTextBox.Text, RussianAlphabet);
        }

        private string DecodeViginere(string text, string key, string alphabet)
        {
            if (!key.All(alphabet.Contains))
                return "";

            var result = new StringBuilder(text.Length);

            var i = 0;
            foreach (var symbol in text)
            {
                var symbolIndex = alphabet.IndexOf(char.ToLower(symbol));
                
                if (-1 != symbolIndex)
                {
                    var keyIndex = alphabet.IndexOf(key[i % key.Length]);
                    ++i;
                    result.Append(
                        alphabet[(symbolIndex - keyIndex + alphabet.Length) % alphabet.Length]);
                }
                else
                    result.Append(symbol);
            }

            return result.ToString();
        }
    }
}
