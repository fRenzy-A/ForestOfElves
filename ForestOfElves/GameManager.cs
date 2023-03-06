using System;
using System.Threading;
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
        static UserInput input = new UserInput();
        static Player player = new Player(map,input);
        static Enemy enemy = new Enemy(player,map);
        static Enemy2 enemy2 = new Enemy2(player, map);
        static Enemy3 enemy3 = new Enemy3(player, map);
        static HUD HUD = new HUD(player,enemy,enemy2,enemy3);
        static Items items = new Items(player);

        public void GameUpdate()
        {
            while (true)
            {
                map.MapDisplay();
                HUD.MainHUD();
                
                player.Update();
                enemy.Update(); 
                items.Update();
                player.Draw();
                input.Input();


                //Thread.Sleep(2000);

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
