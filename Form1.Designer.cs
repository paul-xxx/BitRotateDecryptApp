namespace BitRotateDecryptApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox rawHexTextBox;
        private System.Windows.Forms.TextBox decryptedHexTextBox;
        private System.Windows.Forms.NumericUpDown shiftNumericUpDown;
        private System.Windows.Forms.Label rawHexLabel;
        private System.Windows.Forms.Label decryptedHexLabel;
        private System.Windows.Forms.Label shiftLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.rawHexTextBox = new System.Windows.Forms.TextBox();
            this.decryptedHexTextBox = new System.Windows.Forms.TextBox();
            this.shiftNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.rawHexLabel = new System.Windows.Forms.Label();
            this.decryptedHexLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // rawHexTextBox
            // 
            this.rawHexTextBox.Location = new System.Drawing.Point(12, 50);
            this.rawHexTextBox.Multiline = true;
            this.rawHexTextBox.Name = "rawHexTextBox";
            this.rawHexTextBox.Size = new System.Drawing.Size(338, 207);
            this.rawHexTextBox.TabIndex = 0;
            this.rawHexTextBox.TextChanged += new System.EventHandler(this.rawHexTextBox_TextChanged);
            // 
            // decryptedHexTextBox
            // 
            this.decryptedHexTextBox.Location = new System.Drawing.Point(450, 50);
            this.decryptedHexTextBox.Multiline = true;
            this.decryptedHexTextBox.Name = "decryptedHexTextBox";
            this.decryptedHexTextBox.Size = new System.Drawing.Size(338, 207);
            this.decryptedHexTextBox.TabIndex = 1;
            // 
            // shiftNumericUpDown
            // 
            this.shiftNumericUpDown.Location = new System.Drawing.Point(356, 68);
            this.shiftNumericUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.shiftNumericUpDown.Name = "shiftNumericUpDown";
            this.shiftNumericUpDown.Size = new System.Drawing.Size(88, 20);
            this.shiftNumericUpDown.TabIndex = 2;
            this.shiftNumericUpDown.ValueChanged += new System.EventHandler(this.shiftNumericUpDown_ValueChanged);
            // 
            // rawHexLabel
            // 
            this.rawHexLabel.Location = new System.Drawing.Point(150, 20);
            this.rawHexLabel.Name = "rawHexLabel";
            this.rawHexLabel.Size = new System.Drawing.Size(100, 23);
            this.rawHexLabel.TabIndex = 3;
            this.rawHexLabel.Text = "Raw Hex";
            // 
            // decryptedHexLabel
            // 
            this.decryptedHexLabel.Location = new System.Drawing.Point(550, 20);
            this.decryptedHexLabel.Name = "decryptedHexLabel";
            this.decryptedHexLabel.Size = new System.Drawing.Size(100, 23);
            this.decryptedHexLabel.TabIndex = 4;
            this.decryptedHexLabel.Text = "Decrypted Hex";
            // 
            // shiftLabel
            // 
            this.shiftLabel.Location = new System.Drawing.Point(356, 50);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(88, 15);
            this.shiftLabel.TabIndex = 5;
            this.shiftLabel.Text = "Shift";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 263);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 329);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 604);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rawHexTextBox);
            this.Controls.Add(this.decryptedHexTextBox);
            this.Controls.Add(this.shiftNumericUpDown);
            this.Controls.Add(this.rawHexLabel);
            this.Controls.Add(this.decryptedHexLabel);
            this.Controls.Add(this.shiftLabel);
            this.Name = "Form1";
            this.Text = "Bit Rotate Decrypt App";
            ((System.ComponentModel.ISupportInitialize)(this.shiftNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
