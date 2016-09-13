namespace week10
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
            this.label1 = new System.Windows.Forms.Label();
            this.guessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.nextGuessButton = new System.Windows.Forms.Button();
            this.hintActivateLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.incorrectLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.winLoseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pick a number.\r\nSee if you win.";
            // 
            // guessTextBox
            // 
            this.guessTextBox.Location = new System.Drawing.Point(103, 32);
            this.guessTextBox.Name = "guessTextBox";
            this.guessTextBox.Size = new System.Drawing.Size(67, 20);
            this.guessTextBox.TabIndex = 0;
            this.guessTextBox.Click += new System.EventHandler(this.guessTextBox_Click);
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(202, 29);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 1;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            this.guessButton.Click += new System.EventHandler(this.guessButton_Click);
            // 
            // nextGuessButton
            // 
            this.nextGuessButton.Enabled = false;
            this.nextGuessButton.Location = new System.Drawing.Point(283, 29);
            this.nextGuessButton.Name = "nextGuessButton";
            this.nextGuessButton.Size = new System.Drawing.Size(75, 23);
            this.nextGuessButton.TabIndex = 2;
            this.nextGuessButton.Text = "Next Guess";
            this.nextGuessButton.UseVisualStyleBackColor = true;
            this.nextGuessButton.Click += new System.EventHandler(this.nextGuessButton_Click);
            // 
            // hintActivateLabel
            // 
            this.hintActivateLabel.AutoSize = true;
            this.hintActivateLabel.Location = new System.Drawing.Point(109, 99);
            this.hintActivateLabel.Name = "hintActivateLabel";
            this.hintActivateLabel.Size = new System.Drawing.Size(159, 13);
            this.hintActivateLabel.TabIndex = 4;
            this.hintActivateLabel.Text = "Place your mouse here for a hint";
            this.hintActivateLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.hintActivateLabel_MouseMove);
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.Location = new System.Drawing.Point(109, 123);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(19, 13);
            this.hintLabel.TabIndex = 5;
            this.hintLabel.Text = "??";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.correctLabel.Location = new System.Drawing.Point(269, 152);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(52, 15);
            this.correctLabel.TabIndex = 6;
            this.correctLabel.Text = "Correct:  ";
            // 
            // incorrectLabel
            // 
            this.incorrectLabel.AutoSize = true;
            this.incorrectLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.incorrectLabel.Location = new System.Drawing.Point(269, 178);
            this.incorrectLabel.Name = "incorrectLabel";
            this.incorrectLabel.Size = new System.Drawing.Size(60, 15);
            this.incorrectLabel.TabIndex = 7;
            this.incorrectLabel.Text = "Incorrect:  ";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(128, 208);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 23);
            this.exitButton.TabIndex = 8;
            this.exitButton.TabStop = false;
            this.exitButton.Text = "Exit GuessANumber";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(79, 70);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 13);
            this.errorLabel.TabIndex = 9;
            // 
            // winLoseLabel
            // 
            this.winLoseLabel.AutoSize = true;
            this.winLoseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLoseLabel.ForeColor = System.Drawing.Color.Red;
            this.winLoseLabel.Location = new System.Drawing.Point(42, 152);
            this.winLoseLabel.Name = "winLoseLabel";
            this.winLoseLabel.Size = new System.Drawing.Size(0, 20);
            this.winLoseLabel.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.winLoseLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.incorrectLabel);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.hintActivateLabel);
            this.Controls.Add(this.nextGuessButton);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.guessTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GuessANumber";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nextGuessButton;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.TextBox guessTextBox;
        private System.Windows.Forms.Label hintActivateLabel;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label incorrectLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label winLoseLabel;
    }
}

