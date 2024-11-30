using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTerminal02
{
    internal class GameManager
    {
        private int xWide;
        private int yHigh;
        private int turn = 0;
        private GridManager gridManager;

        public GameManager(int x, int y)
        {
            gridManager = new GridManager(x, y);
        }

        // bắt đầu trận đấu game
        public void startBattle()
        {
            while (true)
            {
                Console.Clear();
                if (gridManager.hpPlayer() == 0)
                {
                    Console.WriteLine("You Loss");
                    break;
                }
                else if (gridManager.numbersEnemy() == 0)
                {
                    Console.WriteLine("You Win");
                    break;
                }
                Console.WriteLine("--------GAME START---------");

                gridManager.info();
                gridManager.spawnTile();  
                if(turn % 2 == 0)
                {
                    Console.WriteLine("Den luot nguoi choi di chuyen : ");
                    turnPlayer();
                }
                else
                {
                    turnEnemy();
                }
                turn++;
            }

            
        }
        //xử lý lượt của người chơi, bao gồm di chuyển hoặc tấn công
        public void turnPlayer()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            gridManager.updatePlayer(key);
        }
        //xử lý lượt của quái, bao gồm di chuyển hoặc tấn công
        public void turnEnemy()
        {
            gridManager.updateEnemy();
        }
    }
}
