using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Map 
    {
        
        public char[,] map = new char[,]
            {
                { '^','0','0','0','0','0','0','^' },
                { '^','0','0','^','0','0','0','^' },
                { '^','0','^','^','^','0','0','^' },
                { '^','0','0','^','0','0','0','^' },
                { '^','0','0','0','0','0','0','^' }
            };
        public bool WallChecker()
        {
            Player player = new Player();
            if (map[player.bufferx,player.buffery] == '0')
            {
                return true;
            }
            else if (map[player.bufferx, player.buffery] != '0')
            {
                return false;
            }
            return true;
            
            //Console.WriteLine(map[player.bufferx, player.buffery]);
        }
        public void MapDisplay()
        {
            int height;
            int width;
            height = map.GetLength(0);
            width = map.GetLength(1);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
        }
    }
}
