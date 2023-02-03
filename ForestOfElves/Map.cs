using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Map 
    {
        
        protected char[,] map = new char[,]
            {
                { '^','^','^','^','^','^','^','^','^','^','^','^','^','^','^','^' },
                { '^','0','0','0','0','0','0','0','0','0','0','0','0','0','0','^' },
                { '^','0','0','0','0','0','0','0','0','0','0','0','0','0','0','^' },
                { '^','0','0','0','0','0','0','0','0','W','0','0','0','0','0','^' },
                { '^','0','0','0','0','0','0','0','0','W','W','0','0','0','0','^' },
                { '^','0','0','W','0','0','0','0','0','0','0','0','0','0','0','^' },
                { '^','0','W','W','0','0','0','0','0','0','0','0','0','0','0','^' },
                { '^','0','W','0','0','0','0','0','0','0','0','0','0','0','0','^' },
                { '^','0','0','0','0','0','0','0','0','W','0','0','0','0','0','^' },
                { '^','0','0','0','0','0','0','0','0','W','W','0','0','0','0','^' },
                { '^','0','0','0','0','0','0','0','0','W','W','0','0','0','0','^' },
                { '^','0','0','0','0','0','0','0','0','W','0','0','0','0','0','^' },
                { '^','0','0','0','0','0','0','0','0','W','0','0','0','0','0','^' },
                { '^','0','0','0','0','0','0','0','0','0','0','0','0','0','0','^' },
                { '^','0','0','0','0','0','0','0','0','0','0','0','0','0','0','^' },
                { '^','^','^','^','^','^','^','^','^','^','^','^','^','^','^','^' }
            };
        public bool WallChecker(int x, int y)
        {
            if (map[y, x] == '0')
            {
                return false;
            }
            if (map[y, x] == 'W')
            {
                return true;
            }
            if (map[y, x] == '^')
            {
                return true;
            }
            
            return false;
        }
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
                    if (map[y, x] == '0')
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    if (map[y, x] == 'W')
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                    }
                    if (map[x, y] == '^')
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                    }
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}
