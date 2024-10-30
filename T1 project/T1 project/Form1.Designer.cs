namespace T1_project
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
            this.components = new System.ComponentModel.Container();
            this.score = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.alien = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.star1 = new System.Windows.Forms.PictureBox();
            this.star2 = new System.Windows.Forms.PictureBox();
            this.GameOver = new System.Windows.Forms.Label();
            this.Restartbtn = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).BeginInit();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.Yellow;
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(161, 48);
            this.score.TabIndex = 4;
            this.score.Text = "Score: 0";
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.BackColor = System.Drawing.Color.Transparent;
            this.highScore.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.ForeColor = System.Drawing.Color.Yellow;
            this.highScore.Location = new System.Drawing.Point(470, 9);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(263, 48);
            this.highScore.TabIndex = 5;
            this.highScore.Text = "High-Score: 0";
            // 
            // alien
            // 
            this.alien.Image = global::T1_project.Properties.Resources._179_1797286_ufo_png_pixel_walking_dead_pixel_art_transparent_removebg_preview__1_;
            this.alien.Location = new System.Drawing.Point(204, 86);
            this.alien.Name = "alien";
            this.alien.Size = new System.Drawing.Size(100, 73);
            this.alien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.alien.TabIndex = 1;
            this.alien.TabStop = false;
            this.alien.Tag = "enemy";
            // 
            // Player
            // 
            this.Player.Image = global::T1_project.Properties.Resources.Player;
            this.Player.Location = new System.Drawing.Point(307, 568);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(120, 120);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            this.Player.Tag = "Player";
            // 
            // star1
            // 
            this.star1.Image = global::T1_project.Properties.Resources.star;
            this.star1.Location = new System.Drawing.Point(-1, 58);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(784, 304);
            this.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star1.TabIndex = 2;
            this.star1.TabStop = false;
            this.star1.Tag = "star";
            // 
            // star2
            // 
            this.star2.Image = global::T1_project.Properties.Resources.star;
            this.star2.Location = new System.Drawing.Point(-1, 470);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(784, 271);
            this.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.star2.TabIndex = 3;
            this.star2.TabStop = false;
            this.star2.Tag = "star";
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.BackColor = System.Drawing.Color.Transparent;
            this.GameOver.Font = new System.Drawing.Font("Segoe Print", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOver.ForeColor = System.Drawing.Color.Red;
            this.GameOver.Location = new System.Drawing.Point(119, 326);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(531, 141);
            this.GameOver.TabIndex = 8;
            this.GameOver.Text = "Game-Over";
            // 
            // Restartbtn
            // 
            this.Restartbtn.AutoSize = true;
            this.Restartbtn.BackColor = System.Drawing.Color.Transparent;
            this.Restartbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Restartbtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Restartbtn.Location = new System.Drawing.Point(577, 470);
            this.Restartbtn.Name = "Restartbtn";
            this.Restartbtn.Size = new System.Drawing.Size(173, 50);
            this.Restartbtn.TabIndex = 9;
            this.Restartbtn.Text = "Restart?";
            this.Restartbtn.Click += new System.EventHandler(this.Restartbtn_Click);
            // 
            // Startbtn
            // 
            this.Startbtn.AutoSize = true;
            this.Startbtn.BackColor = System.Drawing.Color.Transparent;
            this.Startbtn.Font = new System.Drawing.Font("Microsoft YaHei", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbtn.ForeColor = System.Drawing.Color.Red;
            this.Startbtn.Location = new System.Drawing.Point(279, 365);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(208, 80);
            this.Startbtn.TabIndex = 10;
            this.Startbtn.Text = "Start?";
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.Startbtn);
            this.Controls.Add(this.Restartbtn);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.score);
            this.Controls.Add(this.alien);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.star1);
            this.Controls.Add(this.star2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.alien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.star2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox alien;
        private System.Windows.Forms.PictureBox star1;
        private System.Windows.Forms.PictureBox star2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label highScore;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.Label Restartbtn;
        private System.Windows.Forms.Label Startbtn;
        private System.Windows.Forms.Timer timer1;
    }
}

