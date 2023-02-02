using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Player player = new Player();
            while (true)
            {
                Console.WriteLine(map.WallChecker().ToString());
                map.MapDisplay();
                player.PlayerA();
                player.PlayerUpdate(map.WallChecker());
            }
            
        }
        
    }
}
