using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {

        }
        public override void Move(Random random)
        {
            if (this.HitPoints >= 1)
            {
                int rollToMove = random.Next(1, 3);
                if (rollToMove < 3)
                    this.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(2, random);
            }

        }
    }
}
