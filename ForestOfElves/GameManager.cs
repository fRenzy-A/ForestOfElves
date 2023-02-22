using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class GameManager
    {
        Enemy enemy = new Enemy();
        Player player = new Player();
        Map map = new Map();


        
        public void GameUpdate()
        {
            while (true)
            {                
                map.MapDisplay();
                InputUpdate();
            }           
        }

        public void InputUpdate()
        {                        
            enemy.Update();
            player.Update();
        }

        

    }
}
