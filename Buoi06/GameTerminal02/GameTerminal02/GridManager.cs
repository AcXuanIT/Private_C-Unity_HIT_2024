using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal02
{
    internal class GridManager
    {
        private int xWide;
        private int yHigh;

        private List<Character> listEnemy = new List<Character>();
        private Player player = new Player(4,3);

        private Tile[,] listTiles;
        private int numberEnemy = 2;

        private Weapon sword = new Weapon("Light_Sword", 100, 2);
        private Weapon gun = new Weapon("AK", 180, 3);

        //khoi tao gird Manager
        public GridManager(int x, int y)
        {
            this.xWide = x;
            this.yHigh = y;
            this.listTiles = new Tile[x, y];

            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    listTiles[i, j] = new Tile();

            listTiles[player.X, player.Y] = new Tile(player);

            Random random = new Random();
            while(this.numberEnemy > 0)
            {
                int posx = random.Next(xWide);
                int posy = random.Next(yHigh);

                if(posx == player.X && posy == player.Y)
                {
                    continue;
                }
                else
                {
                    listEnemy.Add(new Enemy(posx, posy));
                    listTiles[posx, posy] = new Tile(new Enemy(posx, posy));

                    this.numberEnemy--;
                }
            }
        }
        public void spawnTile()
        {
            for (int i = 0; i < xWide; i++)
            {
                for (int j = 0; j < yHigh; j++)
                {
                    if (listTiles[i, j].isOccupied())
                    {
                        listTiles[i, j].spawnTile();
                    }
                    else
                    {
                        listTiles[i, j].spawnCharacter();
                    }
;                }
                Console.WriteLine();
            }
        }

        public void info()
        {
            Console.WriteLine("HP : " + player.HP);
            Console.WriteLine("Weapon : " + sword.nameWeapon);
/*            for (int i = 0; i < listEnemy.Count; i++)
                Console.WriteLine($"HP Enemy : {listTiles[listEnemy[i].X, listEnemy[i].Y].chrac.HP}");*/
        }
        public int hpPlayer()
        {
            return player.HP;
        }
        public int numbersEnemy()
        {
            return listEnemy.Count;
        }
        public void updatePlayer(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (player.X - 1 < 0)
                    goto checkRange;
                if (!listTiles[player.X - 1, player.Y].isOccupied())
                    goto checkRange;
                listTiles[player.X-1, player.Y] = listTiles[player.X, player.Y];
                listTiles[player.X--, player.Y] = new Tile();
            }
            else if(keyInfo.Key == ConsoleKey.DownArrow)
            {
                if (player.X + 1 >= this.xWide)
                    goto checkRange;
                if (!listTiles[player.X + 1, player.Y].isOccupied())
                    goto checkRange;
                listTiles[player.X +1, player.Y] = listTiles[player.X, player.Y];
                listTiles[player.X++, player.Y] = new Tile();
            }
            else if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (player.Y - 1 < 0)
                    goto checkRange;
                if (!listTiles[player.X, player.Y-1].isOccupied())
                    goto checkRange;
                listTiles[player.X, player.Y-1] = listTiles[player.X, player.Y];
                listTiles[player.X, player.Y--] = new Tile();
            }
            else if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                if (player.Y + 1 >= this.yHigh)
                    goto checkRange;
                if (!listTiles[player.X, player.Y + 1].isOccupied())
                    goto checkRange;
                listTiles[player.X, player.Y+1] = listTiles[player.X, player.Y];
                listTiles[player.X, player.Y++] = new Tile();
            }
            checkRange:
            player.checkRangeAttack(player.Range,listTiles,this.xWide, this.yHigh);

            int i = 0;
            while (i < listEnemy.Count)
            {
                listEnemy[i] = listTiles[listEnemy[i].X, listEnemy[i].Y].chrac;
                if (listEnemy[i].HP == 0)
                {
                    listTiles[listEnemy[i].X, listEnemy[i].Y] = new Tile();
                    listEnemy.RemoveAt(i); 
                }
                else
                {
                    i++; 
                }
            }


        }
        public void updateEnemy()
        {
            for(int k=0;k<listEnemy.Count;k++)
            {
                Random random = new Random();
                int key = random.Next(1,5);
                
                Character moveEnemy = listEnemy[k];
                if (key == 1) //Up
                {
                    if (moveEnemy.X - 1 < 0)
                        goto CheckRange;
                    if (!listTiles[moveEnemy.X - 1, moveEnemy.Y].isOccupied())
                        goto CheckRange;
                    listTiles[moveEnemy.X-1, moveEnemy.Y] = listTiles[moveEnemy.X, moveEnemy.Y];
                    listTiles[moveEnemy.X, moveEnemy.Y] = new Tile();
                    listEnemy[k].X--;
                }
                else if (key == 2) //Down
                {
                    if (moveEnemy.X + 1 >= this.xWide)
                        goto CheckRange;
                    if (!listTiles[moveEnemy.X + 1, moveEnemy.Y].isOccupied())
                        goto CheckRange;
                    listTiles[moveEnemy.X + 1, moveEnemy.Y] = listTiles[moveEnemy.X, moveEnemy.Y];
                    listTiles[moveEnemy.X, moveEnemy.Y] = new Tile();
                    listEnemy[k].X++;
                }
                else if (key == 3) // Left
                {
                    if (moveEnemy.Y - 1 < 0)
                        goto CheckRange;
                    if (!listTiles[moveEnemy.X, moveEnemy.Y-1].isOccupied())
                        goto CheckRange;
                    listTiles[moveEnemy.X, moveEnemy.Y-1] = listTiles[moveEnemy.X, moveEnemy.Y];
                    listTiles[moveEnemy.X, moveEnemy.Y] = new Tile();
                    listEnemy[k].Y--;
                }
                else if (key == 4) // Right
                {
                    if (moveEnemy.Y + 1 >= this.yHigh)
                        goto CheckRange;
                    if (!listTiles[moveEnemy.X, moveEnemy.Y + 1].isOccupied())
                        goto CheckRange;
                    listTiles[moveEnemy.X, moveEnemy.Y + 1] = listTiles[moveEnemy.X, moveEnemy.Y];
                    listTiles[moveEnemy.X, moveEnemy.Y] = new Tile();
                    listEnemy[k].Y++;
                }
                CheckRange:
                moveEnemy.checkRangeAttack(moveEnemy.Range, listTiles, this.xWide, this.yHigh);
            }
          
        }
    }
}
