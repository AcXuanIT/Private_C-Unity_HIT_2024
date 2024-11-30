using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal02
{
    internal class Player : Character
    {
        private Weapon weaponOfPlayer;
        public Player(int x, int y) : base(x, y) { }

        public Weapon wp
        {
            set
            {
                this.wp = value;
                
            }
        }
        public override void attack(int damage, Tile tiled)
        {
            base.attack(damage, tiled);
        }

        public override void checkRangeAttack(int range, Tile[,] list, int x, int y)
        {
            base.checkRangeAttack(range, list, x,y);
        }
    }
}
