using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfejsy336
{
    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        private int numberOfScaryThings;
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave) { this.numberOfScaryThings = numberOfScaryThings; }
        public string ScaryThingIHave
        {
            get { return "Mam " + numberOfScaryThings + " pająków"; }
        }
        public void ScareLittleChildren()
        {
            Console.WriteLine("Buu! Mam cię!");
        }

    }
}
