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
        static Map map = new Map();
        static Player player = new Player(map);
        static Enemy enemy = new Enemy(player,map);
        static HUD HUD = new HUD(player);
        static Items items = new Items(player);
     
        public void GameUpdate()
        {
            while (true)
            {             
                map.MapDisplay();
                HUD.MainHUD();
                




                enemy.Update();
                items.Update();
                player.Update();

                Console.SetCursorPosition(17, 17);
                Console.Write(player.playerX + " " + player.playerY);
                Console.Write(enemy.enemyX + " " + enemy.enemyY + "     ");
                Console.Write(map.mapX);
            }
        }

        public void EnemyKilled()
        {           
            if (player.playerX == enemy.enemyX && player.playerY == enemy.enemyY)
            {
                enemy.dead = true;
                Console.SetCursorPosition(25, 25);
                Console.WriteLine("dead");
                enemy.sprite = "<";
            }        
        }
        
    }
}
