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
        public Map map;
        public UserInput input;
        public Player player;
        //public Enemy enemy;
        public EnemyManager enemies;

        public HUD HUD;
        public Items items;

        public GameManager()
        {
            map = new Map();
            input = new UserInput();
            player = new Player(map,input);
            //enemy = new Enemy(map,player);

            enemies = new EnemyManager(map);

            HUD = new HUD(player, map);
            items = new Items(player);
        }
        public void GameUpdate()
        {
            OnStart();
            while (true)
            {

                map.MapDisplay();

                player.Update(enemies);
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
