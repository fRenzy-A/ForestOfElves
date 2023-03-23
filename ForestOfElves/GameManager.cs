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
        static Random random = new Random();
        static Map map = new Map();
        static UserInput input = new UserInput();
        static Character character = new Character();
        static Player player = new Player(map,input);
        static Grunt grunt = new Grunt(player, map, random);
        
        static EnemyManager enemies = new EnemyManager(player,map,random);
        
        static HUD HUD = new HUD(player, map);
        static Items items = new Items(player);

        
        public void GameUpdate()
        {
            OnStart();
            while (true)
            {
                map.MapDisplay();

                player.Update(enemies.enemy.x,enemies.enemy.y,enemies.enemy);
                enemies.Update();
                //items.Update();
                player.Draw();
                enemies.Draw();
                


                HUD.MainHUD();
                input.Input();
                //Thread.Sleep(2000);

            }
            
        }
        public void OnStart()
        {
            enemies.Start();
        }
    }
}
