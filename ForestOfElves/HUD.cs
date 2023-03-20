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


        static int x;
        static int y;
        public HUD(Player player,Enemy enemy)
        {
            this.player = player;
            this.enemy = enemy;
        }
        public void MainHUD()
        {
            
            
            x = 0;
            y = 21;
            Console.SetCursorPosition(x,y);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Health |H|: " + player.health + "" + "\r\nShield |S|: " + player.shield + "");
            //Console.Write();
            if (enemy.inBattle)
            {
                Console.WriteLine(enemy.health + "");
            }

            if (player.hasKey == 1)
            {
                Console.SetCursorPosition(0,Console.CursorTop);
                Console.WriteLine("|K| Key             ");
            }
            else
            {              
                Console.WriteLine("| | No Key");
            }           
        }

        void BattleInfo()
        {

        }
    }
}
