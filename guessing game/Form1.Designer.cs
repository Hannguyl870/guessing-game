namespace guessing_game
{
    partial class Form1
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
            this.Titleoutput = new System.Windows.Forms.Label();
            this.instructionoutput = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.outputlable = new System.Windows.Forms.Label();
            this.Guessbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titleoutput
            // 
            this.Titleoutput.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titleoutput.Location = new System.Drawing.Point(63, 9);
            this.Titleoutput.Name = "Titleoutput";
            this.Titleoutput.Size = new System.Drawing.Size(262, 41);
            this.Titleoutput.TabIndex = 0;
            this.Titleoutput.Text = "Guessing Game ";
            this.Titleoutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructionoutput
            // 
            this.instructionoutput.Location = new System.Drawing.Point(71, 103);
            this.instructionoutput.Name = "instructionoutput";
            this.instructionoutput.Size = new System.Drawing.Size(220, 23);
            this.instructionoutput.TabIndex = 1;
            this.instructionoutput.Text = "select a number between 1-100";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            // 
            // outputlable
            // 
            this.outputlable.BackColor = System.Drawing.Color.Gray;
            this.outputlable.Location = new System.Drawing.Point(66, 234);
            this.outputlable.Name = "outputlable";
            this.outputlable.Size = new System.Drawing.Size(100, 23);
            this.outputlable.TabIndex = 3;
            // 
            // Guessbutton
            // 
            this.Guessbutton.Location = new System.Drawing.Point(74, 295);
            this.Guessbutton.Name = "Guessbutton";
            this.Guessbutton.Size = new System.Drawing.Size(75, 23);
            this.Guessbutton.TabIndex = 4;
            this.Guessbutton.Text = "Guess";
            this.Guessbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Guessbutton);
            this.Controls.Add(this.outputlable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.instructionoutput);
            this.Controls.Add(this.Titleoutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titleoutput;
        private System.Windows.Forms.Label instructionoutput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label outputlable;
        private System.Windows.Forms.Button Guessbutton;
    }
}

