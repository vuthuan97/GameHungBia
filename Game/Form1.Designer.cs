namespace Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_playGame = new System.Windows.Forms.Label();
            this.lbl_ExitGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_playGame
            // 
            this.lbl_playGame.BackColor = System.Drawing.Color.Transparent;
            this.lbl_playGame.Location = new System.Drawing.Point(227, 404);
            this.lbl_playGame.Name = "lbl_playGame";
            this.lbl_playGame.Size = new System.Drawing.Size(188, 81);
            this.lbl_playGame.TabIndex = 0;
            this.lbl_playGame.Click += new System.EventHandler(this.lbl_playGame_Click);
            // 
            // lbl_ExitGame
            // 
            this.lbl_ExitGame.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ExitGame.Location = new System.Drawing.Point(222, 486);
            this.lbl_ExitGame.Name = "lbl_ExitGame";
            this.lbl_ExitGame.Size = new System.Drawing.Size(152, 78);
            this.lbl_ExitGame.TabIndex = 1;
            this.lbl_ExitGame.Click += new System.EventHandler(this.lbl_ExitGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.Beer_Game;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 661);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_ExitGame);
            this.Controls.Add(this.lbl_playGame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_playGame;
        private System.Windows.Forms.Label lbl_ExitGame;
    }
}

