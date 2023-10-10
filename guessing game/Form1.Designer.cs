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
            this.numberinput = new System.Windows.Forms.TextBox();
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
            // numberinput
            // 
            this.numberinput.Location = new System.Drawing.Point(94, 166);
            this.numberinput.Name = "numberinput";
            this.numberinput.Size = new System.Drawing.Size(113, 22);
            this.numberinput.TabIndex = 2;
            this.numberinput.TextChanged += new System.EventHandler(this.numberinput_TextChanged);
            // 
            // outputlable
            // 
            this.outputlable.BackColor = System.Drawing.Color.Gray;
            this.outputlable.Location = new System.Drawing.Point(81, 302);
            this.outputlable.Name = "outputlable";
            this.outputlable.Size = new System.Drawing.Size(144, 33);
            this.outputlable.TabIndex = 3;
            // 
            // Guessbutton
            // 
            this.Guessbutton.Location = new System.Drawing.Point(94, 225);
            this.Guessbutton.Name = "Guessbutton";
            this.Guessbutton.Size = new System.Drawing.Size(113, 48);
            this.Guessbutton.TabIndex = 4;
            this.Guessbutton.Text = "Guess";
            this.Guessbutton.UseVisualStyleBackColor = true;
            this.Guessbutton.Click += new System.EventHandler(this.Guessbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 450);
            this.Controls.Add(this.Guessbutton);
            this.Controls.Add(this.outputlable);
            this.Controls.Add(this.numberinput);
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
        private System.Windows.Forms.TextBox numberinput;
        private System.Windows.Forms.Label outputlable;
        private System.Windows.Forms.Button Guessbutton;
    }
}

