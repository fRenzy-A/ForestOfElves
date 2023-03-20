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
        static HUD HUD = new HUD(player,enemy);
        static Items items = new Items(player);

        public void GameUpdate()
        {
            while (true)
            {
                map.MapDisplay();
                
                player.Update(enemy.inBattle,enemy.currentEnemyDamage);
                enemy.Update(); 
                items.Update();
                player.Draw();
                enemy.Draw();


                HUD.MainHUD();
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
