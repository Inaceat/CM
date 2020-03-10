using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ColumnarTransposition
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            ushort rows;
            ushort columns;
            try
            {
                rows = ushort.Parse(rowsTextBox.Text);
                columns = ushort.Parse(columnsTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong rectangle size!");
                return;
            }


            //Remove all but letters & digits
            var letters = Regex.Replace(plainTextBox.Text, "[^a-zA-Z0-9а-яёА-ЯЁ]", "");

            cipherTextBox.Text = Encrypt(letters, rows, columns);
        }

        private static string Encrypt(string inputText, int rows, int columns)
        {
            var convertingRectangleSize = rows * columns;

            //Cut input to fit converting rectangle
            if (inputText.Length > convertingRectangleSize)
                inputText = inputText.Substring(0, convertingRectangleSize);


            var convertedText = new StringBuilder(inputText.Length);

            //Iterate columns, "left to right" in converting rectangle
            for (var columnIndex = 0; columnIndex < columns; columnIndex++)
            {
                //In each column, iterate "down"
                for (var rowIndex = 0; rowIndex < rows; rowIndex++)
                {
                    var currentInputIndex = rowIndex * columns + columnIndex;

                    //If input text has char at this index, get it to result
                    if (inputText.Length > currentInputIndex)
                        convertedText.Append(inputText[currentInputIndex]);
                    else
                        //Move to next column
                        break;
                }
            }

            return convertedText.ToString();
        }


        private void decryptButton_Click(object sender, EventArgs e)
        {
            ushort rows;
            ushort columns;
            try
            {
                rows = ushort.Parse(rowsTextBox.Text);
                columns = ushort.Parse(columnsTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong rectangle size!");
                return;
            }
            

            var letters = Regex.Replace(cipherTextBox.Text, "[^a-zA-Z0-9а-яёА-ЯЁ]", "");
            
            plainTextBox.Text = Decrypt(letters, rows, columns);
        }

        private static string Decrypt(string inputText, int rows, int columns)
        {
            //While decrypting, transposed rectangle is used
            (rows, columns) = (columns, rows);

            var convertingRectangleSize = rows * columns;

            //Cut input to fit converting rectangle
            if (inputText.Length > convertingRectangleSize)
                inputText = inputText.Substring(0, convertingRectangleSize);

            //Result storage
            var convertedText = new char[inputText.Length];

            using (var inputChar = inputText.GetEnumerator())
            {
                //Iterate rectangle
                for (var rowIndex = 0; rowIndex < rows; rowIndex++)
                {
                    for (var columnIndex = 0; columnIndex < columns; columnIndex++)
                    {
                        //If current [row, column] rectangle cell should contain letter
                        if (columnIndex * rows + rowIndex < inputText.Length)
                        {
                            //Get next input char
                            inputChar.MoveNext();
                            //And move to appropriate place in output
                            convertedText[columnIndex * rows + rowIndex] = inputChar.Current;
                        }
                    }
                }
            }

            return new string(convertedText);
        }
    }
}
