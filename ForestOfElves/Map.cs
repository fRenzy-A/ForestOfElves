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
            { '^','^','^' },
            { '^','^','^' },
            { '^','^','^' }
        };

        public void MapDisplay()
        {
            int height;
            int width;
            height = map.GetLength(0);
            width = map.GetLength(1);

            for (int y = 0; y < width; y++)
            {
                for (int x = 0; x < height; x++)
                {
                    Console.Write(map[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
