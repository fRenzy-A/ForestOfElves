using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class GameManager
    {
        
        Player player = new Player();
        Enemy enemy = new Enemy();
        Map map = new Map();
     
        public void GameUpdate()
        {
            while (true)
            {
                EnemyKilled();
                map.MapDisplay();

                enemy.Update();
                player.Update();

                Console.SetCursorPosition(17, 17);
                Console.Write(player.playerX + " " + player.playerY);
                Console.Write(enemy.enemyX + " " + enemy.enemyY);
            }
        }

        public void EnemyKilled()
        {
            if (player.playerX == enemy.enemyX && player.playerY == enemy.enemyY)
            {
                Console.SetCursorPosition(25, 25);
                Console.WriteLine("dead");
                enemy.sprite = " ";
                enemy.dead = true;
            }
        
        }
    }
}
