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
            plainTextBox.Text = CaesarShift(cypherTextBox.Text, (int) keyNumericUpDown.Value);
        }

        private string CaesarShift(string text, int shift)
        {
            return text + shift.ToString();
        }
    }
}
