namespace CaesarCipher
{
    partial class MainForm
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
            this.cypherTextBox = new System.Windows.Forms.TextBox();
            this.keyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.decodeButton = new System.Windows.Forms.Button();
            this.plainTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.keyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // cypherTextBox
            // 
            this.cypherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cypherTextBox.Location = new System.Drawing.Point(12, 12);
            this.cypherTextBox.Name = "cypherTextBox";
            this.cypherTextBox.Size = new System.Drawing.Size(776, 23);
            this.cypherTextBox.TabIndex = 0;
            this.cypherTextBox.TabStop = false;
            // 
            // keyNumericUpDown
            // 
            this.keyNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keyNumericUpDown.Location = new System.Drawing.Point(107, 47);
            this.keyNumericUpDown.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.keyNumericUpDown.Name = "keyNumericUpDown";
            this.keyNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.keyNumericUpDown.TabIndex = 1;
            this.keyNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.keyNumericUpDown.ValueChanged += new System.EventHandler(this.keyNumericUpDown_ValueChanged);
            // 
            // decodeButton
            // 
            this.decodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decodeButton.Location = new System.Drawing.Point(12, 41);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.decodeButton.Size = new System.Drawing.Size(89, 32);
            this.decodeButton.TabIndex = 2;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // plainTextBox
            // 
            this.plainTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.plainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.plainTextBox.Location = new System.Drawing.Point(12, 80);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.ReadOnly = true;
            this.plainTextBox.Size = new System.Drawing.Size(776, 358);
            this.plainTextBox.TabIndex = 3;
            this.plainTextBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.keyNumericUpDown);
            this.Controls.Add(this.cypherTextBox);
            this.Name = "MainForm";
            this.Text = "Caesar\'s Cipher";
            ((System.ComponentModel.ISupportInitialize)(this.keyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cypherTextBox;
        private System.Windows.Forms.NumericUpDown keyNumericUpDown;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.TextBox plainTextBox;
    }
}

