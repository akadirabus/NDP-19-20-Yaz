using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPProject
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
         
        }

   

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewGame_Click_1(object sender, EventArgs e)
        {

            string userName = tbUserName.Text;

            Okcu okcu = new Okcu(userName);

            Form1 form1 = new Form1(okcu);
            form1.Show();
            this.Hide();
        }
    }
}
