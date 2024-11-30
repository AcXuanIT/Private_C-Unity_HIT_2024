using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal02
{
    internal abstract class Character
    {
        //thuoc tinh
        private int posX;
        private int posY;
        private int hp = 1000;
        private int damage = 100;
        private int rangeAttack = 1;

        public int X
        {
            get
            {
                return this.posX;
            }
            set
            {
                this.posX = value;
            }
        }
        public int Y
        {
            get
            {
                return this.posY;
            }
            set
            {
                this.posY = value;
            }
        }
        public int HP
        {
            get
            {
                return this.hp;
            }
            set
            {
                this.hp = value;
            }
        }
        public int Range
        {
            get
            {
                return this.rangeAttack;
            }
        }
        public Character(int x, int y)
        {
            this.posX = x;
            this.posY = y;
        }

        public virtual void attack(int damage, Tile tiled)
        {
            tiled.chrac.HP = tiled.chrac.HP - this.damage;
        }

        public virtual void checkRangeAttack(int range, Tile[,] list, int x, int y)
        {
            for (int i = 1; i <= range; i++)
            {
                if(this.X - i >= 0)
                if (!list[this.X - i, this.Y].isOccupied())
                {
                    attack(damage, list[this.X - i, this.Y]);
                }
                if(this.X + i < x)
                if (!list[this.X + i, this.Y].isOccupied())
                {
                    attack(damage, list[this.X + i, this.Y]);
                }
                if(this.Y - i >= 0)
                if (!list[this.X, this.Y - i].isOccupied())
                {
                    attack(damage, list[this.X, this.Y - i]);
                }
                if(this.Y + i < y)
                if (!list[this.X, this.Y + i].isOccupied())
                {
                    attack(damage, list[this.X, this.Y + i]);
                }
            }
        }
        
        
    }
}
