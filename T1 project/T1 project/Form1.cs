using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T1_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GameOver.Hide();
            Restartbtn.Hide();
            timer1.Stop();
        }

        bool right, left, space;
        int point, highestpnt;
        PictureBox bullet;

        //Di chuyển và khởi tạo vị trí ngẫu nhiên cho quái vật
        void enemyMovement()
        {
            Random rnd = new Random();
            int x, y;
            if (alien.Top >= 600)
            {
                x = rnd.Next(0, 300);
                alien.Location = new Point(x, 0);
            }
            else
            {
                alien.Top += 15;
            }
        }

        //Di chuyển của người chơi
        void arrowKeyMovement()
        {
            if (right == true)
            {
                if (Player.Left < 450)
                {
                    Player.Left += 20;
                }
            }
            if (left == true)
            {
                if (Player.Left > 10)
                {
                    Player.Left -= 20;
                }
            }
        }

        //Bắn đạn bằng phím space
        void shooting()
        {
            bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image = Properties.Resources.bullet;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = Player.Left + 50;
            bullet.Top = Player.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }

        //Đường bay của đạn
        void bulletMovement()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 20;
                    if (x.Top < 50)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }
        }

        //Hàm xét sự va chạm và cập nhật điểm, highscore
        void Game()
        {
            foreach (Control i in this.Controls)
            {
                foreach (Control j in this.Controls)
                {
                    if (i is PictureBox && i.Tag == "bullet")
                    {
                        if (j is PictureBox && j.Tag == "enemy")
                        {
                            if (i.Bounds.IntersectsWith(j.Bounds))
                            {
                                j.Top += 600;
                                point++;
                                score.Text = "Score: " + point;
                                this.Controls.Remove(i);
                            }
                        }
                    }
                }
            }
            if (Player.Bounds.IntersectsWith(alien.Bounds))
            {
                timer1.Stop();
                GameOver.Show();
                GameOver.BringToFront();
                Restartbtn.Show();
                Restartbtn.BringToFront();
                if (highestpnt < point)
                {
                    highestpnt = point;
                    highScore.Text = "High-Score: " + highestpnt;
                }
            }
        }

        //Chuyển động của môi trường
        void Star()
        {
            foreach (Control i in this.Controls)
            {
                if (i is PictureBox && i.Tag == "star")
                {
                    i.Top += 20;
                    if (i.Top > 600)
                    {
                        i.Top = -200;
                    }
                }
            }
        }


        private void Startbtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            Startbtn.Hide();
        }

        private void Restartbtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            GameOver.Hide();
            Restartbtn.Hide();
            Player.Location = new Point(250, 480);
            alien.Location = new Point(167, 52);
            point = 0;
            score.Text = "Score: " + point;
            this.Controls.Remove(bullet);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) right = true;
            if (e.KeyCode == Keys.Left) left = true;
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                shooting();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) right = false;
            if (e.KeyCode == Keys.Left) left = false;
            if (e.KeyCode == Keys.Space) space = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            arrowKeyMovement();
            enemyMovement();
            bulletMovement();
            Star();
            Game();
        }
    }
}
