using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class HUD
    {
        Player player;

        public HUD(Player player)
        {
            this.player = player;
        }
        public void MainHUD()
        {          
            Map map = new Map();
            Console.SetCursorPosition(0,17);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Health: " + player.health);     
            Console.WriteLine("Shield: " + player.shield);
        }
    }
}
