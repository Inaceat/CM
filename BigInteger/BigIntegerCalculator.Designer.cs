namespace BigInteger
{
    partial class BigIntegerCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.isPrimeButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.isPrimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.firstNumberTextBox.Location = new System.Drawing.Point(13, 13);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(403, 23);
            this.firstNumberTextBox.TabIndex = 0;
            this.firstNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.resultTextBox.Location = new System.Drawing.Point(12, 172);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.Size = new System.Drawing.Size(404, 23);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.secondNumberTextBox.Location = new System.Drawing.Point(13, 50);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(403, 23);
            this.secondNumberTextBox.TabIndex = 2;
            this.secondNumberTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.addButton.Location = new System.Drawing.Point(93, 91);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 59);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // isPrimeButton
            // 
            this.isPrimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.isPrimeButton.Location = new System.Drawing.Point(422, 8);
            this.isPrimeButton.Name = "isPrimeButton";
            this.isPrimeButton.Size = new System.Drawing.Size(75, 32);
            this.isPrimeButton.TabIndex = 4;
            this.isPrimeButton.Text = "Is prime?";
            this.isPrimeButton.UseVisualStyleBackColor = true;
            this.isPrimeButton.Click += new System.EventHandler(this.isPrimeButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.multiplyButton.Location = new System.Drawing.Point(255, 91);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(75, 59);
            this.multiplyButton.TabIndex = 5;
            this.multiplyButton.Text = "x";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.subtractButton.Location = new System.Drawing.Point(174, 91);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 59);
            this.subtractButton.TabIndex = 6;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // isPrimeLabel
            // 
            this.isPrimeLabel.AutoSize = true;
            this.isPrimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.isPrimeLabel.Location = new System.Drawing.Point(503, 11);
            this.isPrimeLabel.Name = "isPrimeLabel";
            this.isPrimeLabel.Size = new System.Drawing.Size(46, 25);
            this.isPrimeLabel.TabIndex = 7;
            this.isPrimeLabel.Text = "Yes";
            // 
            // BigInteger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 223);
            this.Controls.Add(this.isPrimeLabel);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.isPrimeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Name = "BigInteger";
            this.Text = "Big Integers Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button isPrimeButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Label isPrimeLabel;
    }
}

