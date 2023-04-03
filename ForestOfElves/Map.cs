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
        public char[][] publicMap;

        

        public Map(Renderer renderer)
        {
            this.renderer = renderer;
            publicMap = new char[textmap.Length][];
            for (int i = 0; i < textmap.Length; i++)
            {
                publicMap[i] = textmap[i].ToCharArray();
            }
            renderer.drawData = new char[publicMap.Length][];
           // renderer.drawData = publicMap;
        }
        public void DrawMap()
        {
            //Array.Clear(renderer.drawData, 0, renderer.drawData.Length);
            
            for (int i = 0; i < publicMap.Length; i++)
            {
                renderer.drawData[i] = publicMap[i];             
            }
            /*Console.SetCursorPosition(0, 0);
            foreach (char[] map in publicMap)
            {
                ColorMap(map);
                Console.WriteLine();
            }
            Console.ResetColor();*/
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

        public void MapUpdate()
        {

        }

        
        public bool IsWallAt(int x, int y)
        {
            if (publicMap[y][x] == 'W')
            {
                return true;
            }
            if (publicMap[y][x] == '^')
            {
                return true;
            }           
            if (publicMap[y][x] == 'T')
            {
                return true;
            }
            return false;
        }

        public bool IsDoorAt(int x, int y)
        {
            if (publicMap[y][x] == 'I')
            {
                return true;
            }
            return false;

        }
    }
}
