namespace ColumnarTransposition
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
            this.cipherTextBox = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.decryptButton = new System.Windows.Forms.Button();
            this.rowsTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.columnsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // plainTextBox
            // 
            this.plainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.plainTextBox.Location = new System.Drawing.Point(12, 12);
            this.plainTextBox.Multiline = true;
            this.plainTextBox.Name = "plainTextBox";
            this.plainTextBox.Size = new System.Drawing.Size(770, 201);
            this.plainTextBox.TabIndex = 0;
            // 
            // cipherTextBox
            // 
            this.cipherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cipherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cipherTextBox.Location = new System.Drawing.Point(12, 288);
            this.cipherTextBox.Multiline = true;
            this.cipherTextBox.Name = "cipherTextBox";
            this.cipherTextBox.Size = new System.Drawing.Size(770, 201);
            this.cipherTextBox.TabIndex = 1;
            // 
            // encryptButton
            // 
            this.encryptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.encryptButton.Location = new System.Drawing.Point(243, 219);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(75, 63);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "Encrypt \\/";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // decryptButton
            // 
            this.decryptButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.decryptButton.Location = new System.Drawing.Point(452, 219);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(75, 63);
            this.decryptButton.TabIndex = 3;
            this.decryptButton.Text = "Decrypt /\\";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // rowsTextBox
            // 
            this.rowsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rowsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rowsTextBox.Location = new System.Drawing.Point(324, 241);
            this.rowsTextBox.Name = "rowsTextBox";
            this.rowsTextBox.Size = new System.Drawing.Size(47, 22);
            this.rowsTextBox.TabIndex = 4;
            this.rowsTextBox.Text = "2";
            this.rowsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(377, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "X";
            // 
            // columnsTextBox
            // 
            this.columnsTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.columnsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.columnsTextBox.Location = new System.Drawing.Point(399, 241);
            this.columnsTextBox.Name = "columnsTextBox";
            this.columnsTextBox.Size = new System.Drawing.Size(47, 22);
            this.columnsTextBox.TabIndex = 7;
            this.columnsTextBox.Text = "3";
            this.columnsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 501);
            this.Controls.Add(this.columnsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rowsTextBox);
            this.Controls.Add(this.decryptButton);
            this.Controls.Add(this.encryptButton);
            this.Controls.Add(this.cipherTextBox);
            this.Controls.Add(this.plainTextBox);
            this.Name = "MainForm";
            this.Text = "Columnar transposition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plainTextBox;
        private System.Windows.Forms.TextBox cipherTextBox;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox rowsTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox columnsTextBox;
    }
}

