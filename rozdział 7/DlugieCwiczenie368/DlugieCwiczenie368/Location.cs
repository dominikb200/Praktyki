using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DlugieCwiczenie368
{
    abstract class Location
    {
        public string Name { get; private set; }
        public Location(string name)
        {
            Name = name;
        }
        public Location[] Exits;
        public virtual string Description
        {
            get { string descrition = "Stoisz w: " + Name + ". Widzisz wyjścia do następujących lokalizacji: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    descrition += " " + Exits[i].Name;
                    if (i != Exits.Length - 1) { descrition += ","; }
                }
                descrition += ".";
                return descrition;
            }
            
        }
    }

}
