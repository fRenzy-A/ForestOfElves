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
            string[,] map = new string[textmap.Length, textmap[0].Length];
            publicMap = map;


            for (int x = 0; x < textmap.Length; x++)
            {
                string line = textmap[x];
                char[] split = line.ToCharArray();
                for (int y = 0; y < line.Length; y++)
                {             
                    string mapCharacter = split[y].ToString();
                    renderer.RenderGame(mapCharacter, y, x);
                    map[x, y] = mapCharacter;
                }
                
            }
        }
      
        public bool IsWallAt(int x, int y)
        {
            switch (publicMap[y, x])
            {
                default:
                    return false;
                case "^":
                    return true;
                case "W":
                    return true;
                case "T":
                    return true;
            }
        }

        public bool IsDoorAt(int x, int y)
        {
            if (publicMap[y,x] == "I")
            {
                return true;
            }
            return false;
        }
    }
}
