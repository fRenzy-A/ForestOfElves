using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Program
    {
        static CharacterManager health = new CharacterManager();
        static Map map = new Map();
        static Player player = new Player();
        static Enemy enemy = new Enemy();
        static void Main(string[] args)
        {           
            enemy.currentX = 5;
            enemy.currentY = 5;

            player.currentX = 3;
            player.currentY = 3;
            health.Kill();
            while (true)
            {
                //Console.WriteLine(health.health.ToString());
                map.MapDisplay();
                enemy.EnemyManager(health.health);
                player.PlayerManager();
                
                Console.Clear();
            }
        }

        
    }
}
