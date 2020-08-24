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
    public partial class ScoreTable : Form
    {
        public ScoreTable()
        {
            InitializeComponent();

        }

        private void ScoreTable_Load(object sender, EventArgs e)
        {
            
            string file = ".\\score.txt";
            pbPlayer.ImageLocation= "./images/archer.png";

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Kullanıcı Adı", 150);
            listView1.Columns.Add("Puan", 70);


            FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);

            StreamReader sw = new StreamReader(fs);

            string yazi = sw.ReadLine();
            string[] playerInfo;

            List<Okcu> players = new List<Okcu>();



            while (yazi != null)
            {
               
                Console.WriteLine(yazi);

                playerInfo = yazi.Split('-');

                string userName=playerInfo[0];
                int score= Convert.ToInt32(playerInfo[1]);

                Okcu player = new Okcu(userName,score);

                players.Add(player);

                yazi = sw.ReadLine();
            }

            sw.Close();
            fs.Close();

            int y = 0;
            while (players.Count > y)
            {
                
                
                string[] row = { players[y].GetUserName(), players[y].GetScore().ToString() };
                var satir = new ListViewItem(row);
                listView1.Items.Add(satir);

                y++;
            }


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
     
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Show();
            this.Hide();
        }

        private void btnPlayback_Click(object sender, EventArgs e)
        {
            PlaybackLastGame playbackLastGame = new PlaybackLastGame();

            playbackLastGame.Show();
            this.Hide();
        }
    }
}
