namespace FormGame
{
    partial class FormGame
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
            this.pbHangman = new System.Windows.Forms.PictureBox();
            this.lblHangman = new System.Windows.Forms.Label();
            this.lblWord = new System.Windows.Forms.Label();
            this.lblTriesLeft = new System.Windows.Forms.Label();
            this.lblTries = new System.Windows.Forms.Label();
            this.tbLetter = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblAlready = new System.Windows.Forms.Label();
            this.lblEntered = new System.Windows.Forms.Label();
            this.btnGiveUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).BeginInit();
            this.SuspendLayout();
            // 
            // pbHangman
            // 
            this.pbHangman.Location = new System.Drawing.Point(79, 218);
            this.pbHangman.Name = "pbHangman";
            this.pbHangman.Size = new System.Drawing.Size(320, 447);
            this.pbHangman.TabIndex = 0;
            this.pbHangman.TabStop = false;
            // 
            // lblHangman
            // 
            this.lblHangman.AutoSize = true;
            this.lblHangman.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangman.Location = new System.Drawing.Point(234, 49);
            this.lblHangman.Name = "lblHangman";
            this.lblHangman.Size = new System.Drawing.Size(221, 46);
            this.lblHangman.TabIndex = 1;
            this.lblHangman.Text = "HANGMAN";
            this.lblHangman.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWord
            // 
            this.lblWord.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWord.Location = new System.Drawing.Point(29, 140);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(625, 43);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "Donaudampfschifffahrtsgesellschaft";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTriesLeft
            // 
            this.lblTriesLeft.AutoSize = true;
            this.lblTriesLeft.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTriesLeft.Location = new System.Drawing.Point(152, 682);
            this.lblTriesLeft.Name = "lblTriesLeft";
            this.lblTriesLeft.Size = new System.Drawing.Size(96, 24);
            this.lblTriesLeft.TabIndex = 3;
            this.lblTriesLeft.Text = "Tries left:";
            // 
            // lblTries
            // 
            this.lblTries.AutoSize = true;
            this.lblTries.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTries.Location = new System.Drawing.Point(278, 682);
            this.lblTries.Name = "lblTries";
            this.lblTries.Size = new System.Drawing.Size(32, 24);
            this.lblTries.TabIndex = 4;
            this.lblTries.Text = "10";
            // 
            // tbLetter
            // 
            this.tbLetter.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLetter.Location = new System.Drawing.Point(502, 268);
            this.tbLetter.Name = "tbLetter";
            this.tbLetter.Size = new System.Drawing.Size(50, 40);
            this.tbLetter.TabIndex = 5;
            this.tbLetter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbLetter_KeyDown);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Location = new System.Drawing.Point(462, 337);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(125, 49);
            this.btnEnter.TabIndex = 6;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblAlready
            // 
            this.lblAlready.AutoSize = true;
            this.lblAlready.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlready.Location = new System.Drawing.Point(440, 470);
            this.lblAlready.Name = "lblAlready";
            this.lblAlready.Size = new System.Drawing.Size(159, 24);
            this.lblAlready.TabIndex = 7;
            this.lblAlready.Text = "Already entered:";
            // 
            // lblEntered
            // 
            this.lblEntered.AutoSize = true;
            this.lblEntered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntered.Location = new System.Drawing.Point(458, 526);
            this.lblEntered.Name = "lblEntered";
            this.lblEntered.Size = new System.Drawing.Size(0, 24);
            this.lblEntered.TabIndex = 8;
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiveUp.Location = new System.Drawing.Point(502, 670);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(125, 49);
            this.btnGiveUp.TabIndex = 9;
            this.btnGiveUp.Text = "Give Up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 745);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.lblEntered);
            this.Controls.Add(this.lblAlready);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.tbLetter);
            this.Controls.Add(this.lblTries);
            this.Controls.Add(this.lblTriesLeft);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.lblHangman);
            this.Controls.Add(this.pbHangman);
            this.Name = "FormGame";
            this.Text = "Hangman";
            ((System.ComponentModel.ISupportInitialize)(this.pbHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHangman;
        private System.Windows.Forms.Label lblHangman;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Label lblTriesLeft;
        private System.Windows.Forms.Label lblTries;
        private System.Windows.Forms.TextBox tbLetter;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblAlready;
        private System.Windows.Forms.Label lblEntered;
        private System.Windows.Forms.Button btnGiveUp;
    }
}

