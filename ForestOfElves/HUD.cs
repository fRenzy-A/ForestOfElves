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
        Map map;


        static int x;
        static int y;
        public HUD(Player player, Map map)
        {
            this.player = player;
            this.map = map;
        }
        public void ShowHUD()
        {
            

            x = 0;
            y = map.publicMap.GetLength(0);
            Console.SetCursorPosition(x,y);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Health |H|: " + player.health + "     ");
            Console.WriteLine("Shield |S|: " + player.shield + "     ");
            Console.WriteLine("Health Potions: " + player.howManyPotions + " -Press J to use"+"   ");
            Console.WriteLine("Shield Parts: " + player.howManyShields + " -Press L to use"+"   ");
            Console.WriteLine();
            Console.WriteLine("WASD TO MOVE. GET ALL KEY PARTS[<] TO UNLOCK DOOR[Brown] AND BEAT THE BOSS");
            if (player.keyParts == 1)
            {
                Console.Write("|^| Half Key             ");
            }
            if (player.keyParts == 2)
            {
                Console.Write("|K| Key             ");
            }
            if (player.keyParts == 0)
            {              
                Console.Write("| | No Key");
            }
            
        }

        
    }
}
