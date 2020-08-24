using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPProject
{
    public partial class Level2 : Form
    {
        string userName;
        int score;

        public Level2(string u, int s)
        {
            InitializeComponent();
         
            userName = u;
            score = s;
            lblScore.Text = score.ToString();
        }

        private void Level2_Load(object sender, EventArgs e)
        {
            pbBalloon1.Visible = false;
            pbBalloon2.Visible = false;
            pbBalloon3.Visible = false;

            pbPlayer.ImageLocation = "./images/archer.png";
            pbArrow.ImageLocation = "./images/arrow.png";
            pbBalloon1.ImageLocation = "./images/balloon-green.png";
            pbBalloon2.ImageLocation = "./images/balloon-yellow.png";
            pbBalloon3.ImageLocation = "./images/balloon-green.png";
        }


        void Game()
        {
            Random rand = new Random();
            int x, y, z;

            if (pbArrow.Bounds.IntersectsWith(pbBalloon1.Bounds))
            {
                pbBalloon1.Top = 20;
                x = rand.Next(180, 700);
                pbBalloon1.Location = new Point(x, 20);
                score += 15;
                lblScore.Text = "Puan: " + score;
                pbBalloon1.Visible = false;

            }
            if (pbArrow.Bounds.IntersectsWith(pbBalloon2.Bounds))
            {
                pbBalloon2.Top = 20;
                y = rand.Next(180, 700);
                pbBalloon2.Location = new Point(y, 20);
                score += 5;
                lblScore.Text = "Puan: " + score;
                pbBalloon2.Visible = false;

            }
            if (pbArrow.Bounds.IntersectsWith(pbBalloon3.Bounds))
            {
                pbBalloon3.Top = 20;
                z = rand.Next(180, 700);
                pbBalloon3.Location = new Point(z, 20);
                score += 5;
                lblScore.Text = "Puan: " + score;
                pbBalloon3.Visible = false;

            }
            if (score >= 200)
            {
                timer1.Stop();
                if (MessageBox.Show("Tebrikler " + userName + " ilk bölümü başarıyla tamamladın. Bir sonraki bölüme geçmek ister misin?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Level3 level3 = new Level3(userName,score);

                    this.Hide();
                    level3.Show();

                }


            }
        }

        void GameOver()
        {
            timer1.Stop();

            string file = ".\\score.txt";

            FileStream fs = new FileStream(file, FileMode.Append, FileAccess.Write, FileShare.Write);

            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(userName + "-" + score + "-" + DateTime.Now.ToString("D"));
            sw.Flush();

            sw.Close();



            if (MessageBox.Show("Tebrikler " + userName + " puanın: " + score, "Yeni Oyun?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                StartPage startPage = new StartPage();
                this.Hide();
                startPage.Show();
            }
            else
            {
                ScoreTable scoreTable = new ScoreTable();
                this.Hide();
                scoreTable.Show();
            }
        }

        void Balloon()
        {
            pbBalloon1.Visible = true;
            pbBalloon2.Visible = true;
            pbBalloon3.Visible = true;

            if (pbBalloon1.Top > 500 || pbBalloon2.Top > 500 || pbBalloon3.Top > 500)
            {
                GameOver();
            }
            else
            {
                pbBalloon1.Top += 7;
                pbBalloon2.Top += 9;
                pbBalloon3.Top += 11;

            }
        }


        void Shoot()
        {
            pbArrow.Left += 100;
            if (pbArrow.Left > 700) { }
            {
                //pbArrow.Image = Properties.Resources.arrow;
                pbArrow.Top = pbPlayer.Top + 55;
            }
        }

        private void Level2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                pbArrow.Visible = true;
                pbArrow.Left = pbPlayer.Left + 115;
            }


            if (e.KeyCode == Keys.Up)
            {
                if (pbPlayer.Top > 50)
                {
                    pbPlayer.Top -= 20;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (pbPlayer.Top < 400)
                {
                    pbPlayer.Top += 20;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Shoot();
            Balloon();
            Game();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pbPlayer_Click(object sender, EventArgs e)
        {

        }
    }
}
