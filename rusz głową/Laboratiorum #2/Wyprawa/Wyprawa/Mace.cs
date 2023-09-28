using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class Mace : Weapon
    {
        public Mace(Game game, Point location) : base(game, location) { }
        public override string Name { get { return "Bulawa"; } }
        public override void Attack(Direction direction, Random random)
        {
            Direction nextSwing = direction;
            Direction secondSwing = direction;
            Direction thirdSwing = direction;
            switch (direction)
            {
                case Direction.Up:
                    nextSwing = Direction.Left;
                    secondSwing = Direction.Down;
                    thirdSwing = Direction.Right;
                    break;
                case Direction.Left:
                    nextSwing = Direction.Down;
                    secondSwing = Direction.Right;
                    thirdSwing = Direction.Up;
                    break;
                case Direction.Down:
                    nextSwing = Direction.Right;
                    secondSwing = Direction.Up;
                    thirdSwing = Direction.Left;
                    break;
                case Direction.Right:
                    nextSwing = Direction.Up;
                    secondSwing = Direction.Left;
                    thirdSwing = Direction.Down;
                    break;
            }
            DamageEnemy(direction, 35, 6, random);
            DamageEnemy(nextSwing, 35, 6, random);
            DamageEnemy(secondSwing, 35, 6, random);
            DamageEnemy(thirdSwing, 35, 6, random);
        }
    }
}