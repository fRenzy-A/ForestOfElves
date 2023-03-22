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
        //static Enemy enemy = new Enemy(player,map);
        static Grunt grunt = new Grunt(player,map,random);
        static Grunt grunt1 = new Grunt(player, map,random);
        static HUD HUD = new HUD(player, map);
        static Items items = new Items(player);


        public void OnStart()
        {

        }
        public void GameUpdate()
        {
            while (true)
            {
                input.Input();
                map.MapDisplay();
                
                for (int i = 0; i < 3; i++)
                {
                    
                }

                player.Update();
                grunt.Update();
                //grunt1.Update();
                items.Update();
                player.Draw();
                grunt.Draw();
               // grunt1.Draw();


                HUD.MainHUD();
                
                //Thread.Sleep(2000);

            }
            
        }
        
    }
}
