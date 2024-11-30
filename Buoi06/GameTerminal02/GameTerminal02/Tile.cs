using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal02
{
    internal class Tile
    {
        private Character character;
        private int posX;
        private int posY;
        public Character chrac
        {
            get
            {
                return this.character;
            }
            set
            {
                this.character = value;
            }
        }
        public Tile() { }
        public Tile(Character crt)
        {
            this.posX = crt.X;
            this.posY = crt.Y;
            this.character = crt;
        }
        public bool isOccupied()
        {
            return character == null;
        }
        public void spawnTile()
        {
            Console.Write("X");
        }
        public void spawnCharacter()
        {
            if (character is Player)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("0");
                Console.ResetColor();
            }
            if(character is Enemy)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1");
                Console.ResetColor();
            }
        }
    }
}
