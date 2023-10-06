using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8)
        {

        }
        public override void Move(Random random)
        {
            if (this.HitPoints >= 1)
            {
                int rollToMove = random.Next(1, 3);
                if (rollToMove == 1)
                    this.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(3, random);
            }

        }
    }
}
