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
        EnemyManager enemy;
        Map map;

        int removeDelay = 3;

        static int x;
        static int y;
        public HUD(Player player, Map map, EnemyManager enemy)
        {
            this.player = player;
            this.enemy = enemy;
            this.map = map;
        }
        public void MainHUD()
        {
            
            
            x = 0;
            y = map.publicMap.GetLength(0);
            Console.SetCursorPosition(x,y);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Health |H|: " + player.health + "     ");
            Console.WriteLine("Shield |S|: " + player.shield + "     ");
            if (player.hasKey == 1)
            {
                Console.SetCursorPosition(0,Console.CursorTop);
                Console.WriteLine("|K| Key             ");
            }
            else
            {              
                Console.WriteLine("| | No Key");
            }
            //BattleInfo();
            //Console.WriteLine(enemy.attacked);
        }

        /*void BattleInfo()
        {
            
            if (player.inBattle)
            {
                Console.WriteLine("Enemy HP: " + enemy.health + "    ");
                if (enemy.health == 0)
                {
                    removeDelay--;
                    Console.WriteLine("Enemy defeated");
                    if (removeDelay == 0)
                    {
                        Console.WriteLine("                ");
                    }
                }
            }
        }*/
    }
}
