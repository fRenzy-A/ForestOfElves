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
        public Renderer renderer;
        public Map map;
        public UserInput input;
        public Player player;
        public Random random;
        public EnemyManager enemies;
        public ItemManager items;
        public HUD HUD;
        public Character character;
        public bool endGame;
        public bool playerBeatBoss;
        public GameManager(UserInput input)
        {
            random = new Random();           
            renderer = new Renderer();
            map = new Map(renderer);
            character = new Character(renderer);    
            this.input = input;
            player = new Player(map,input,renderer);
            enemies = new EnemyManager(map,random,player,renderer);
            items = new ItemManager(map,player,random,renderer);
            HUD = new HUD(player, map);
            renderer.GetMapSize(map.textmap.Length, map.textmap[0].Length);
        }

        public void GameUpdate()
        {
            endGame = false;
            playerBeatBoss = false;
            OnStart();

            while (!endGame)
            {
                map.DrawMap();

                player.Update(enemies);
                enemies.Update();
                items.Update();

                player.Draw();
                enemies.Draw();
                items.Draw();

                HUD.ShowHUD();


                if (player.playerDied)
                {
                    Reset();
                    endGame = true;
                }
                if (player.killedBoss)
                {
                    Reset();
                    playerBeatBoss = true;
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



        public void Reset()
        {
            renderer.Reset();   
            enemies.DeleteAll();
            items.DeleteAll();
        }


    }
}
