using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class GameManager
    {
        

        public void GameLoop()
        {
            Map map = new Map();
            Player player = new Player();
            
            map.MapDisplay();
            player.PlayerManager(3,3);
        }
    }
}
