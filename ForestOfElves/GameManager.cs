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
        public GameManager(UserInput input)
        {
            random = new Random();           
            renderer = new Renderer();
            map = new Map(renderer);
            character = new Character(renderer);    
            this.input = input;
            player = new Player(map,input,random,renderer);
            enemies = new EnemyManager(map,random,player,renderer);
            items = new ItemManager(map,player,random,renderer);
            HUD = new HUD(player, map);
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


                map.DrawMap();
                player.Draw();
                enemies.Draw();
                items.Draw();


                HUD.MainHUD();
                renderer.RenderGame();


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
