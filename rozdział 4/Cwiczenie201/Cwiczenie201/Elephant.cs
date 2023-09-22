using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenie201
{
    internal class Elephant
    {
        public String Name;
        public int EarSize;

        public void WhoAmI()
        {
            MessageBox.Show("Moje uszy mają " + EarSize + " centymetrów szerokości", Name + " mówi...");
        }
    }
}
