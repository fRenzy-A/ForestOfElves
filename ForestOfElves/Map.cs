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


        public Map()
        {
            string[,] map = new string[textmap.Length, textmap[0].Split(' ').Length];
            publicMap = map;
        }
        public void DisplayMap()
        {

            Console.SetCursorPosition(0, 0);
            for (int x = 0; x < textmap.Length; x++)
            {
                string line = textmap[x];
                for (int y = 0; y < publicMap.GetLength(1); y++)
                {                   
                    string[] split = line.Split(' ');
                    publicMap[x, y] = split[y];
                    if (publicMap[x, y] == "0")
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (publicMap[x, y] == "W")                   
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    if (publicMap[x, y] == "T")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }
                    if (publicMap[x, y] == "^")
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                    if (publicMap[x, y] == "B")
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    if (publicMap[x, y] == "I")
                    {
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    }
                    Console.Write(publicMap[x,y]);    
                }
                Console.WriteLine();        
            }
            Console.ResetColor();
        }
        
        public bool IsWallAt(int x, int y)
        {
            if (publicMap[y, x] == "W")
            {
                return true;
            }
            if (publicMap[y, x] == "^")
            {
                return true;
            }           
            if (publicMap[y, x] == "T")
            {
                return true;
            }
            return false;
        }

        public bool IsDoorAt(int x, int y)
        {
            if (publicMap[y, x] == "I")
            {
                return true;
            }
            return false;

        }
    }
}
