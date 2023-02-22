using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class GameManager
    {
        Enemy enemy = new Enemy();
        Player player = new Player();
        public int playerX = 3;
        public int playerY = 4;
        
        public int enemyX = 6;
        public int enemyY = 6;

        static Random random = new Random();
        
        public void InputUpdate()
        {
            int randomMove = random.Next(1, 5);
            player.PlayerDraw(playerX, playerY);
            //enemy.EnemyDraw(enemyX,enemyY);
            ConsoleKeyInfo KeyInfo;
            KeyInfo = Console.ReadKey(true);

            if (KeyInfo.Key == ConsoleKey.W)
            {

                if (randomMove == 1)
                {
                    enemyX--;
                }
                else if (randomMove == 2)
                {
                    enemyY--;
                }
                else if (randomMove == 3)
                {
                    enemyX++;
                }
                else if (randomMove == 4)
                {
                    enemyY++;
                }
                player.PlayerDraw(playerX, playerY--);
            }
            if (KeyInfo.Key == ConsoleKey.A)
            {
                if (randomMove == 1)
                {
                    enemyX--;
                }
                else if (randomMove == 2)
                {
                    enemyY--;
                }
                else if (randomMove == 3)
                {
                    enemyX++;
                }
                else if (randomMove == 4)
                {
                    enemyY++;
                }
                player.PlayerDraw(playerX--, playerY);
            }
            if (KeyInfo.Key == ConsoleKey.S)
            {
                if(randomMove == 1)
                {
                    enemyX--;
                }
                else if (randomMove == 2)
                {
                    enemyY--;
                }
                else if (randomMove == 3)
                {
                    enemyX++;
                }
                else if (randomMove == 4)
                {
                    enemyY++;
                }
                player.PlayerDraw(playerX, playerY++);
            }
            if (KeyInfo.Key == ConsoleKey.D)
            {
                if (randomMove == 1)
                {
                    enemyX--;
                }
                else if (randomMove == 2)
                {
                    enemyY--;
                }
                else if (randomMove == 3)
                {
                    enemyX++;
                }
                else if (randomMove == 4)
                {
                    enemyY++;
                }
                player.PlayerDraw(playerX++, playerY);
            }
            
        }

    }
}
