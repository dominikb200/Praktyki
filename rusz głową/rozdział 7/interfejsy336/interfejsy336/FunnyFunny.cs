using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfejsy336
{
    internal class FunnyFunny : IClown
    {
        public string funnyThingIHave;
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        public string FunnyThingIHave { get { return "Cześć dzieciaki! Mam " + funnyThingIHave; } }
        public void Honk()
        {
            Console.Write(this.funnyThingIHave);
        }
    }
}
