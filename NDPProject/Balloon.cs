using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDPProject
{
    public class Balloon
    {
        private string Type;
        private int LocationX;
        private int LocationY;
        private string ImageLocation;

        public Balloon(string type, int locationX, int locationY, string imageLocation)
        {
            Type = type;
            LocationX = locationX;
            LocationY = locationY;
            ImageLocation = imageLocation;
        }
        
        public PictureBox GetPictureBox()
        {
            var picture = new PictureBox
            {
                Name = Type,
                Size = new Size(16, 16),
                Location = new Point(LocationX,LocationY),
                ImageLocation =ImageLocation

            };
            return picture;
        }
        
        public string GetImageLocation()
        {
            return ImageLocation;
        }

        public void SetImageLocation(string imageLocation)
        {
            ImageLocation = imageLocation;
        }

        public string GetType()
        {
            return Type;
        }

        public void SetType(string type)
        {
            Type = type;
        }
        public int GetLocationX()
        {
            return LocationX;
        }
        public void SetLocationX(int location)
        {
            LocationX = location;
        }
        public int GetLocationY()
        {
            return LocationY;
        }
        public void SetLocationY(int location)
        {
            LocationY = location;
        }
        public void Drop(int dropLevel)
        {
            LocationY -= dropLevel;
        }
    }
}
