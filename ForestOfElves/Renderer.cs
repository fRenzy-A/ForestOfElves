using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Renderer
    {
        public string[,] previousInstance;
        public string[,] currentInstance;

        public void RenderGame(string Character, int x, int y)
        {
            currentInstance[y, x] = Character;
            DoubleBuffer(Character, x, y);
        }
        public void GetMapSize(int x, int y)
        {
            previousInstance = new string[x, y];
            currentInstance = new string[x, y];
        }

        public void DoubleBuffer(string character, int x, int y)
        {
            if (previousInstance[y,x] == currentInstance[y,x])
            {
                return;
            }
            else
            {
                Console.SetCursorPosition(x, y);
                ColorGame(character);
                Console.Write(currentInstance[y, x]);
                Console.ResetColor();
            }
            previousInstance[y,x] = currentInstance[y,x];
        }
        public void ColorGame(string character)
        {
            switch (character)
            {
                case "0":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "W":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "^":
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case "T":
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "X":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "I":
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "H":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case "S":
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case "&":
                    Console.BackgroundColor= ConsoleColor.DarkGreen;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "▓":
                    Console.BackgroundColor= ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case "¤":
                    Console.BackgroundColor= ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "§":
                    Console.BackgroundColor= ConsoleColor.DarkRed;
                    Console.ForegroundColor= ConsoleColor.Black;
                    break;
                case "<":
                    Console.BackgroundColor= ConsoleColor.DarkYellow;
                    Console.ForegroundColor= ConsoleColor.Yellow;
                    break ;
                case "k":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
        public void Reset()
        {
            Array.Clear(currentInstance, 0, currentInstance.Length);
            Array.Clear(previousInstance, 0, previousInstance.Length);
        }
    }
}
