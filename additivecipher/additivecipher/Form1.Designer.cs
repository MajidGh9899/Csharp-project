namespace additivecipher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.input = new System.Windows.Forms.TextBox();
            this.Find = new System.Windows.Forms.Button();
            this.output = new System.Windows.Forms.TextBox();
            this.cipherText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(99, 60);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(314, 29);
            this.input.TabIndex = 0;
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(99, 112);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(137, 41);
            this.Find.TabIndex = 1;
            this.Find.Text = "FInd";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // output
            // 
            this.output.Location = new System.Drawing.Point(460, 60);
            this.output.Multiline = true;
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(311, 527);
            this.output.TabIndex = 2;
            // 
            // cipherText
            // 
            this.cipherText.AutoSize = true;
            this.cipherText.Location = new System.Drawing.Point(14, 60);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(79, 21);
            this.cipherText.TabIndex = 3;
            this.cipherText.Text = "cipherText";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "PlainText";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 626);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.output);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Label cipherText;
        private System.Windows.Forms.Label label1;
    }
}
