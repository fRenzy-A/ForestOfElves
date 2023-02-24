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
        Enemy enemy;
        Enemy2 enemy2;
        Enemy3 enemy3;

        static int x;
        static int y;
        public HUD(Player player,Enemy enemy, Enemy2 enemy2, Enemy3 enemy3)
        {
            this.player = player;
            this.enemy = enemy;
            this.enemy2 = enemy2;
            this.enemy3 = enemy3;
        }
        public void MainHUD()
        {
            x = 0;
            y = 21;
            Console.SetCursorPosition(x,y);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Health |H|: " + player.health);     
            Console.WriteLine("Shield |S|: " + player.shield);
            if (enemy.attacked)
            {
                Console.WriteLine("Fast Grunt is dead         ");
            }
            if (enemy2.attacked)
            {
                Console.WriteLine("Linear Skewer is dead       ");
            }
            if (enemy3.attacked)
            {
                Console.WriteLine("Grunt is dead        ");
            }
            if (player.hasKey == 1)
            {
                Console.Write("              ");
                Console.SetCursorPosition(0,Console.CursorTop);
                Console.Write("|K| Key");
            }
            else
            {
                
                Console.Write("| | No Key");
            }
            
        }
    }
}
