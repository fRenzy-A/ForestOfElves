using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    
    internal class Map
    {
        Renderer renderer;

        public string[] textmap = System.IO.File.ReadAllLines(@"MapFile.txt");
        public string[,] publicMap;



        public Map(Renderer renderer)
        {
            this.renderer = renderer;
            
        }
        public void DrawMap()
        {




            publicMap = new string[textmap.Length, textmap[0].Split('\n').Length];;
            for (int x = 0; x < textmap.Length; x++)
            {
                string line = textmap[x];
                for (int y = 0; y < publicMap.GetLength(1); y++)
                {
                    string[] split = line.Split('\n');
                    publicMap[x, y] = split[y];
                    renderer.RenderGame(publicMap[x, y], y, x);
                }
            }


            /*foreach (char[] map in publicMap)
            {
                foreach (char c in map)
                {
                    renderer.RenderGame(c,map.Length,publicMap.Length);
                }
                Console.WriteLine();

            }*/
            //Console.ResetColor();
        }
        public void ColorMap(char[] map)
        {
            /*foreach (char c in map)
            {
                switch (c)
                {
                    case '0':
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case 'W':
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case '^':
                        Console.BackgroundColor = ConsoleColor.DarkGray;
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        break;
                    case 'I':
                        Console.BackgroundColor = ConsoleColor.DarkYellow;
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        break;
                    case 'T':
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.Black;
                        break;
                }
                Console.Write(c);
            }*/
        }
      
        public bool IsWallAt(int x, int y)
        {
            if (publicMap[y,x] == "^")
            {
                return true;
            }           
            else if (publicMap[y,x] == "W")
            {
                return true;
            }
            else if (publicMap[y,x] == "T")
            {
                return true;
            }
            return false;
        }

        public bool IsDoorAt(int x, int y)
        {
            if (publicMap[x,y] == "I")
            {
                return true;
            }
            return false;
        }
    }
}
