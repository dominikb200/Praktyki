using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDzienNaWyscigach225
{
    internal class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public String GetDescription()
        {
            if (Amount != 0)
            {
                return Bettor.Name + " postawił " + Bettor.MyBet.Amount + " na psa numer " + Bettor.MyBet.Dog;
            }
            else
            {
                return Bettor.Name + " nie postawił zakładu";
            }
        }

        public int PayOut(int Winner)
        {
            if (Bettor.MyBet.Dog == Winner)
            {
                return Amount;
            }
            else
            {
                return -Amount;
            }
        }
    }
}
