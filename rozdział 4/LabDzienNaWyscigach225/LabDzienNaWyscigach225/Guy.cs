using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDzienNaWyscigach225
{
    internal class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " ma " + Cash + " zł";
            MyLabel.Text = MyBet.GetDescription();
        }

        public void ClearBet ()
        {
            MyBet = null;
        }

        public bool PlaceBet(int Amount, int DogToWin)
        {
            MyBet = new Bet() { Amount = Amount, Dog = DogToWin, Bettor = this };
            if (Cash >= 5)
            {
                return true;
            }
            else return false;
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
        }

        public void DisableRadioButton()
        {
            MyRadioButton.Enabled = false;
        }

        public void EnableRadioButton()
        {
            MyRadioButton.Enabled = true;
        }
    }
}
