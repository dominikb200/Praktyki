using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDzienNaWyscigach225
{
    internal class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()
        {
            Location += MyRandom.Next(1, 4);
            MyPictureBox.Left += Location;
            if(MyPictureBox.Right >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            MyPictureBox.Left = StartingPosition;
            Location = 0;
        }
    }
}
