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

        static int x;
        static int y;
        public HUD(Player player)
        {
            this.player = player;
        }
        public void MainHUD()
        {
            x = 0;
            y = 21;
            Console.SetCursorPosition(x,y);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Health: " + player.health);     
            Console.WriteLine("Shield: " + player.shield);
            if (player.hasKey == 1)
            {
                Console.Write("              ");
                Console.SetCursorPosition(0,Console.CursorTop);
                Console.Write("K | Key");
            }
            else
            {
                
                Console.Write("  | No Key");
            }
        }
    }
}
