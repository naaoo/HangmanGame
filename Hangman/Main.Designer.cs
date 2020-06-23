namespace Hangman
{
    partial class Main
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
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.cbPlayer = new System.Windows.Forms.ComboBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblHangman = new System.Windows.Forms.Label();
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.lblHighscore = new System.Windows.Forms.Label();
            this.lblDivider1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMenu
            // 
            this.pbMenu.Location = new System.Drawing.Point(40, 123);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(290, 400);
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            // 
            // cbPlayer
            // 
            this.cbPlayer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlayer.FormattingEnabled = true;
            this.cbPlayer.Location = new System.Drawing.Point(584, 123);
            this.cbPlayer.Name = "cbPlayer";
            this.cbPlayer.Size = new System.Drawing.Size(121, 29);
            this.cbPlayer.TabIndex = 2;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(390, 123);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(120, 21);
            this.lblPlayer.TabIndex = 1;
            this.lblPlayer.Text = "Choose Player:";
            // 
            // lblHangman
            // 
            this.lblHangman.AutoSize = true;
            this.lblHangman.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangman.Location = new System.Drawing.Point(309, 30);
            this.lblHangman.Name = "lblHangman";
            this.lblHangman.Size = new System.Drawing.Size(221, 46);
            this.lblHangman.TabIndex = 0;
            this.lblHangman.Text = "HANGMAN";
            // 
            // lblDifficulty
            // 
            this.lblDifficulty.AutoSize = true;
            this.lblDifficulty.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficulty.Location = new System.Drawing.Point(390, 169);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(140, 21);
            this.lblDifficulty.TabIndex = 3;
            this.lblDifficulty.Text = "Choose Difficulty:";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Location = new System.Drawing.Point(584, 169);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(121, 29);
            this.cbDifficulty.TabIndex = 4;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(503, 220);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(100, 43);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(467, 310);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(175, 21);
            this.lblAdd.TabIndex = 6;
            this.lblAdd.Text = "Add Words or Players:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(503, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 43);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddClick);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(503, 480);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(100, 43);
            this.btnView.TabIndex = 9;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // lblHighscore
            // 
            this.lblHighscore.AutoSize = true;
            this.lblHighscore.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighscore.Location = new System.Drawing.Point(489, 437);
            this.lblHighscore.Name = "lblHighscore";
            this.lblHighscore.Size = new System.Drawing.Size(138, 21);
            this.lblHighscore.TabIndex = 8;
            this.lblHighscore.Text = "View Highscores:";
            // 
            // lblDivider1
            // 
            this.lblDivider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDivider1.Location = new System.Drawing.Point(347, 289);
            this.lblDivider1.Name = "lblDivider1";
            this.lblDivider1.Size = new System.Drawing.Size(412, 2);
            this.lblDivider1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(347, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 2);
            this.label1.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 572);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDivider1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.lblHighscore);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblDifficulty);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.lblHangman);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.cbPlayer);
            this.Controls.Add(this.pbMenu);
            this.Name = "Main";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.ComboBox cbPlayer;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblHangman;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.ComboBox cbDifficulty;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label lblHighscore;
        private System.Windows.Forms.Label lblDivider1;
        private System.Windows.Forms.Label label1;
    }
}

