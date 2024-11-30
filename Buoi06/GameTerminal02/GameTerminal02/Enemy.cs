using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal02
{
    internal class Enemy : Character
    {
        public Enemy(int x, int y) : base(x, y)
        {
        }

        public override void attack(int damage, Tile tiled)
        {
            if (tiled.chrac is Enemy)
                return;
            base.attack(damage, tiled);
        }

        public override void checkRangeAttack(int range, Tile[,] list, int x, int y)
        {
            base.checkRangeAttack(range, list, x, y);
        }
    }
}
