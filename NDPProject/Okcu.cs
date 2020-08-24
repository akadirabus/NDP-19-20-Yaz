using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProject
{
    public class Okcu
    {
        private string UserName;
        private int Score=0;

        public string GetUserName() 
        {
            return UserName;
        }
        public void SetUserName(string userName)
        {
            UserName = userName;
        }
        public int GetScore() 
        {
            return Score;
        }
        public void SetScore(int score) 
        {
            Score = score;
        }
        public Okcu(string userName, int score=0)
        {
            UserName = userName;
            Score = score;
        }

      
    }
}
