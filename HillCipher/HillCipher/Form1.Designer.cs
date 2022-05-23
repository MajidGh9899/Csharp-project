namespace HillCipher
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
            this.Plaintext = new System.Windows.Forms.TextBox();
            this.Ciphertext = new System.Windows.Forms.TextBox();
            this.Enbtn = new System.Windows.Forms.Button();
            this.Debtn = new System.Windows.Forms.Button();
            this.keytext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inverse = new System.Windows.Forms.CheckBox();
            this.MsgMat = new System.Windows.Forms.Label();
            this.KetMat = new System.Windows.Forms.Label();
            this.invemat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Plaintext
            // 
            this.Plaintext.Location = new System.Drawing.Point(157, 37);
            this.Plaintext.Name = "Plaintext";
            this.Plaintext.Size = new System.Drawing.Size(277, 29);
            this.Plaintext.TabIndex = 0;
            this.Plaintext.Text = "hiiran";
            // 
            // Ciphertext
            // 
            this.Ciphertext.Location = new System.Drawing.Point(157, 336);
            this.Ciphertext.Name = "Ciphertext";
            this.Ciphertext.Size = new System.Drawing.Size(306, 29);
            this.Ciphertext.TabIndex = 1;
            // 
            // Enbtn
            // 
            this.Enbtn.Location = new System.Drawing.Point(157, 222);
            this.Enbtn.Name = "Enbtn";
            this.Enbtn.Size = new System.Drawing.Size(118, 74);
            this.Enbtn.TabIndex = 2;
            this.Enbtn.Text = "Encrypt";
            this.Enbtn.UseVisualStyleBackColor = true;
            this.Enbtn.Click += new System.EventHandler(this.Enbtn_Click);
            // 
            // Debtn
            // 
            this.Debtn.Location = new System.Drawing.Point(0, 0);
            this.Debtn.Name = "Debtn";
            this.Debtn.Size = new System.Drawing.Size(75, 23);
            this.Debtn.TabIndex = 12;
            // 
            // keytext
            // 
            this.keytext.Location = new System.Drawing.Point(157, 113);
            this.keytext.MaxLength = 4;
            this.keytext.Name = "keytext";
            this.keytext.Size = new System.Drawing.Size(268, 29);
            this.keytext.TabIndex = 4;
            this.keytext.Text = "hill";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result";
            // 
            // inverse
            // 
            this.inverse.AutoSize = true;
            this.inverse.Location = new System.Drawing.Point(157, 148);
            this.inverse.Name = "inverse";
            this.inverse.Size = new System.Drawing.Size(82, 25);
            this.inverse.TabIndex = 8;
            this.inverse.Text = "Inverse";
            this.inverse.UseVisualStyleBackColor = true;
            this.inverse.CheckedChanged += new System.EventHandler(this.inverse_CheckedChanged);
            // 
            // MsgMat
            // 
            this.MsgMat.AutoSize = true;
            this.MsgMat.Location = new System.Drawing.Point(496, 42);
            this.MsgMat.Name = "MsgMat";
            this.MsgMat.Size = new System.Drawing.Size(0, 21);
            this.MsgMat.TabIndex = 9;
            // 
            // KetMat
            // 
            this.KetMat.AutoSize = true;
            this.KetMat.Location = new System.Drawing.Point(496, 121);
            this.KetMat.Name = "KetMat";
            this.KetMat.Size = new System.Drawing.Size(0, 21);
            this.KetMat.TabIndex = 10;
            // 
            // invemat
            // 
            this.invemat.AutoSize = true;
            this.invemat.Location = new System.Drawing.Point(514, 152);
            this.invemat.Name = "invemat";
            this.invemat.Size = new System.Drawing.Size(58, 21);
            this.invemat.TabIndex = 11;
            this.invemat.Text = "invmat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invemat);
            this.Controls.Add(this.KetMat);
            this.Controls.Add(this.MsgMat);
            this.Controls.Add(this.inverse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.keytext);
            this.Controls.Add(this.Debtn);
            this.Controls.Add(this.Enbtn);
            this.Controls.Add(this.Ciphertext);
            this.Controls.Add(this.Plaintext);
            this.Name = "Form1";
            this.Text = "Hill Cipher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Plaintext;
        private System.Windows.Forms.TextBox Ciphertext;
        private System.Windows.Forms.Button Enbtn;
        private System.Windows.Forms.Button Debtn;
        private System.Windows.Forms.TextBox keytext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox inverse;
        private System.Windows.Forms.Label MsgMat;
        private System.Windows.Forms.Label KetMat;
        private System.Windows.Forms.Label invemat;
    }
}
