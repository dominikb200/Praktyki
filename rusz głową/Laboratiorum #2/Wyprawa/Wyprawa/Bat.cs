using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6) { }
        public override void Move(Random random)
        {
            if (this.HitPoints >= 1)
            {
                int rollToMove = random.Next(1, 2);
                if (rollToMove == 1)
                {
                    this.location = Move((Direction)random.Next(1, 4), game.Boundaries);
                }
                else
                    Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(2, random);
            }
        }
    }
}
