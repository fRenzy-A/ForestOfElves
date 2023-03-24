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
        public Random random;
        //public Enemy enemy;
        public EnemyManager enemies;
        public ItemManager items;

        public HUD HUD;


        public GameManager()
        {
            random = new Random();
            map = new Map();
            input = new UserInput();
            player = new Player(map,input,random);
            //enemy = new Enemy(map,player);

            enemies = new EnemyManager(map,random,player);
            items = new ItemManager(map,player,random);

            HUD = new HUD(player, map);
        }
        public void GameUpdate()
        {
            Console.SetWindowSize(100, 60);

            //OnStart();
            while (true)
            {

                map.DisplayMap();

                player.Update(enemies);
                enemies.Update();
                items.Update();
                player.Draw();
                enemies.Draw();
                items.Draw();



                HUD.MainHUD();
                input.Input();

            }

        }
        public void OnStart()
        {
            enemies.OnStart();
        }




    }
}
