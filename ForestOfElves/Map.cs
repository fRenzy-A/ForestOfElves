using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Map 
    {
        /*public char[,] map = new char[,]
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
            };*/

        public string[] textmap = System.IO.File.ReadAllLines(@"MapFile.txt");

        public string[,] publicMap;
        public void MapDisplay()
        {
            string[,] map = new string[textmap.Length, textmap[0].Split(' ').Length];
            publicMap = map;
            //string[,] map = new string[textmap.GetLength(0),textmap.GetLength(1)];



            Console.SetCursorPosition(0, 0);
            for (int x = 0; x < textmap.Length; x++)
            {
                string line = textmap[x];
                for (int y = 0; y < map.GetLength(1); y++)
                {                   
                    string[] split = line.Split(' ');
                    map[x, y] = split[y];
                    if (map[x, y] == "0")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (map[x, y] == "W")
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    if (map[x, y] == "^")
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    if (map[x, y] == "B")
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    if (map[x, y] == "I")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.Write(map[x,y]);    
                }
                Console.WriteLine();        
            }
            Console.ResetColor();
        }
        
        public bool WallChecker(int x, int y)
        {
            if (publicMap[y, x] == "W")
            {
                return true;
            }
            if (publicMap[y, x] == "^")
            {
                return true;
            }           
            return false;
        }

        public void DoorChecker(int x, int y, int hasKey)
        {
            if (publicMap[y, x] == "I" && hasKey == 1)
            {

            }

        }
    }
}
