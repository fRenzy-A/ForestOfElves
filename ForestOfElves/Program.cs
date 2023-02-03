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
        static void Main(string[] args)
        {
            Map map = new Map();
            Player player = new Player();
            Enemy enemy = new Enemy();
            while (true)
            {
                map.MapDisplay();
                enemy.EnemyManager();
                player.PlayerManager();        
                Console.Clear();
            }
        }       
    }
}
