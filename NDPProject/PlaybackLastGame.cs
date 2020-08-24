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
    public partial class PlaybackLastGame : Form
    {

        int score = 0;
        List<Tuple<int, int>> playbackList = new List<Tuple<int, int>>();

        public PlaybackLastGame()
        {
            InitializeComponent();
            
        }

        private void PlaybackLastGame_Load(object sender, EventArgs e)
        {
            pbBalloon1.Visible = false;
            pbBalloon2.Visible = false;
            pbBalloon3.Visible = false;
            lblScore.Visible = false;
            pbPlayer.Visible = false;
            pbArrow.Visible = false;

            pbPlayer.ImageLocation = "./images/archer.png";
            pbArrow.ImageLocation = "./images/arrow.png";
            pbBalloon1.ImageLocation = "./images/balloon-green.png";
            pbBalloon2.ImageLocation = "./images/balloon-green.png";
            pbBalloon3.ImageLocation = "./images/balloon-green.png";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pbBalloon1.Visible = true;
            pbBalloon2.Visible = true;
            pbBalloon3.Visible = true;
            lblScore.Visible = true;
            pbPlayer.Visible = true;
            pbArrow.Visible = true;
            btnStart.Visible = false;
            btnStart.Enabled = false;

            timer1.Enabled = true;


            FileStream fs = new FileStream("playback.txt", FileMode.Open, FileAccess.Read);

            StreamReader sw = new StreamReader(fs);

            string[] splitText;

            string read = sw.ReadLine();
            
            while (read != null)
            {

                Console.WriteLine(read);


                splitText = read.Split(',');

                //Time Split
                string read_time = splitText[0];

                read_time = read_time.Replace('(', ' ');

                //Move Split
                string read_move = splitText[1];

                read_move = read_move.Replace(')', ' ');

                playbackList.Add(Tuple.Create(Convert.ToInt32(read_time), Convert.ToInt32(read_move)));

                read = sw.ReadLine();
            }

            sw.Close();
            fs.Close();

           

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
         
        }

        void GameOver()
        {
            timer1.Stop();

          
          
        }

        int count = 0;
        int playback_time;
        int playback_move;

        void Playback()
        {
             
           
            while (count < playbackList.Count)
            {
                playback_time = playbackList[count].Item1;
                playback_move = playbackList[count].Item2;

                if (playback_move == 1)
                {
                    //playback(1) = SAĞ

                    pbArrow.Visible = true;
                    pbArrow.Left = pbPlayer.Left + 115;

                    count++;
                    break;
                }

                else if (playback_move == 2)
                {
                    //playback(2) = YUKARI

                    if (pbPlayer.Top > 50)
                    {
                        pbPlayer.Top -= 20;
                        count++;
                        break;
                    }
                   
                }

                else if (playback_move == 3)
                {
                    //playback(3) = AŞAĞI

                    if (pbPlayer.Top < 400)
                    {
                        pbPlayer.Top += 20;
                        count++;
                        break;
                    }
                }
                count++;
                break;
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Playback();
            Shoot();
            Balloon();
            Game();
        }
    }
}
