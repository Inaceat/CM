namespace VigenereCipher
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
            this.plainTextBox = new System.Windows.Forms.TextBox();
            this.decodeButton = new System.Windows.Forms.Button();
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plainTextBox
            // 
            this.plainTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.plainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.plainTextBox.Location = new System.Drawing.Point(12, 219);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.ReadOnly = true;
            this.plainTextBox.Size = new System.Drawing.Size(776, 219);
            this.plainTextBox.TabIndex = 7;
            this.plainTextBox.TabStop = false;
            // 
            // decodeButton
            // 
            this.decodeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.decodeButton.Location = new System.Drawing.Point(272, 185);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.decodeButton.Size = new System.Drawing.Size(89, 32);
            this.decodeButton.TabIndex = 6;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cipherTextBox.Location = new System.Drawing.Point(12, 12);
            this.cipherTextBox.Multiline = true;
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(776, 167);
            this.cipherTextBox.TabIndex = 4;
            this.cipherTextBox.TabStop = false;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.keyTextBox.Location = new System.Drawing.Point(12, 190);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(254, 23);
            this.keyTextBox.TabIndex = 8;
            this.keyTextBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.cipherTextBox);
            this.Name = "MainForm";
            this.Text = "VigenereCipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
    }
}

