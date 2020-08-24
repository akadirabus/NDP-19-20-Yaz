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
    public partial class Form1 : Form
    {
        readonly string userName;
        int score = 0;

        List<Tuple<int, int>> playbackList = new List<Tuple<int, int>>();

        public Form1(Okcu okcu)
        {
            
            InitializeComponent();

            userName = okcu.GetUserName();
            score = okcu.GetScore();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            pbBalloon1.Visible = false;
            pbBalloon2.Visible = false;
            pbBalloon3.Visible = false;

            pbPlayer.ImageLocation = "./images/archer.png";
            pbArrow.ImageLocation = "./images/arrow.png";
            pbBalloon1.ImageLocation = "./images/balloon-green.png";
            pbBalloon2.ImageLocation = "./images/balloon-green.png";
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
                score += 5;
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
            if (score == 100)
            {
                timer1.Stop();
                if (MessageBox.Show("Tebrikler " + userName + " ilk bölümü başarıyla tamamladın. Bir sonraki bölüme geçmek ister misin?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Level2 level2 = new Level2(userName, score);

                    this.Hide();
                    level2.Show();

                }


            }
        }

        void GameOver()
        {
            timer1.Stop();

            string fileScore = ".\\score.txt";

            FileStream fs_score = new FileStream(fileScore, FileMode.Append, FileAccess.Write, FileShare.Write);

            StreamWriter sw_score = new StreamWriter(fs_score);

            sw_score.WriteLine(userName + "-" + score + "-" + DateTime.Now.ToString("D"));
            sw_score.Flush();

            sw_score.Close();

            string filePlayback = ".\\playback.txt";

            //Son Kullanıcı Playback Veri Kaydet
            FileStream fs_playback = new FileStream(filePlayback, FileMode.Truncate, FileAccess.Write, FileShare.Write);
            StreamWriter sw_playback = new StreamWriter(fs_playback);

            for (int i = 0; i < playbackList.Count; i++)
            {
                sw_playback.WriteLine(playbackList[i]);         
            }
          
            sw_playback.Flush();

            sw_playback.Close();

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
                pbBalloon1.Top += 5;
                pbBalloon2.Top += 7;
                pbBalloon3.Top += 9;

            }
        }

        void Shoot()
        {
            pbArrow.Left += 100;
            if (pbArrow.Left > 700) { }
            {
                // pbArrow.Image = Properties.Resources.arrow;
                pbArrow.Top = pbPlayer.Top + 55;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
         
            if (e.KeyCode == Keys.Right)
            {
                //playback(1) = SAĞ
                playbackList.Add(Tuple.Create(timer, 1));
                timer++;

                pbArrow.Visible = true;
                pbArrow.Left = pbPlayer.Left + 115;

            }

            if (e.KeyCode == Keys.Up)
            {
                //playback(2) = YUKARI
                playbackList.Add(Tuple.Create(timer, 2));
                timer++;

                if (pbPlayer.Top > 50)
                {
                    pbPlayer.Top -= 20;
                }

            }

            if (e.KeyCode == Keys.Down)
            {
                //playback(3) = AŞAĞI
                playbackList.Add(Tuple.Create(timer, 3));
                timer++;

                if (pbPlayer.Top < 400)
                {
                    pbPlayer.Top += 20;
                }
            }
        }

        int timer=0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //playback(0)
            playbackList.Add(Tuple.Create(timer, 0));

            Shoot();
            Balloon();
            Game();

            timer++;
        
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void pbPlayer_Click(object sender, EventArgs e)
        {

        }

        private void pbArrow_Click(object sender, EventArgs e)
        {

        }

        private void pbBalloon3_Click(object sender, EventArgs e)
        {

        }
    }
}
