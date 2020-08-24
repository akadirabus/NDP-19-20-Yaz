using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPProject
{
    public class Ok
    {
        public int LocationX { get; set; }
        public int Count { get; set; } = 50;

        public int GetLocationX()
        {
            return LocationX;
        }
        public void SetLocationX(int x)
        {
            LocationX = x;
        }

    }
}
