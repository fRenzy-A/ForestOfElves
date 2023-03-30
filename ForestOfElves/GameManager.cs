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
        public EnemyManager enemies;
        public ItemManager items;
        public HUD HUD;
        public DoubleBuffer doubleBuffer;
        public bool endGame;
        public GameManager(UserInput input)
        {
            random = new Random();
            map = new Map();
            this.input = input;
            player = new Player(map,input,random);
            enemies = new EnemyManager(map,random,player);
            items = new ItemManager(map,player,random);
            HUD = new HUD(player, map);
            doubleBuffer = new DoubleBuffer();
        }

        public void GameUpdate()
        {
            Console.SetWindowSize(100, 60);
            endGame = false;
            OnStart();
            while (!endGame)
            {

                player.Update(enemies);
                enemies.Update();
                items.Update();


                //doubleBuffer.previousInstance[][] { map.DrawMap(); player.Draw(); }
                map.DrawMap();
                player.Draw();
                enemies.Draw();
                items.Draw();

                HUD.MainHUD();


                if (player.PlayerDied())
                {
                    ClearScreenEntities();
                    endGame = true;
                }
                
                input.Input();

            }
            


        }
        public void OnStart()
        {             
            player.OnStart();
            enemies.OnStart();
            items.OnStart();
        }



        public void ClearScreenEntities()
        {
            enemies.DeleteAll();
            items.DeleteAll();
        }


    }
}
