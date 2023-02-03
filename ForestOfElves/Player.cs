using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Player
    {
        
        static int currentX = 3;
        static int currentY = 3;

        public int bufferX = currentX;
        public int bufferY = currentY;
  
        public void PlayerManager()
        {
            Position(currentX, currentY);
            PlayerUpdate();
        }
        static void Position(int x, int y)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write("X");
        }
        
        public void PlayerUpdate()
        {
            ConsoleKeyInfo KeyInfo;
            KeyInfo = Console.ReadKey(true);
            Map map = new Map();
            if (KeyInfo.Key == ConsoleKey.W)
            {
                bufferY--;
                if (map.WallChecker(bufferX,bufferY) == false)
                {
                    currentY = bufferY;
                }
                else if (map.WallChecker(bufferX, bufferY) == true)
                {
                    bufferY++;
                }
            }
            if (KeyInfo.Key == ConsoleKey.A)
            {
                bufferX--;
                if (map.WallChecker(bufferX, bufferY) == false)
                {
                    currentX = bufferX;
                }
                else if (map.WallChecker(bufferX, bufferY) == true)
                {
                    bufferX++;
                }
            }
            if (KeyInfo.Key == ConsoleKey.S)
            {
                bufferY++;
                if (map.WallChecker(bufferX, bufferY) == false)
                {
                    currentY = bufferY;
                }
                else if (map.WallChecker(bufferX, bufferY) == true)
                {
                    bufferY--;
                }
            }
            if (KeyInfo.Key == ConsoleKey.D)
            {
                bufferX++;
                if (map.WallChecker(bufferX, bufferY) == false)
                {
                    currentX = bufferX;
                }
                else if (map.WallChecker(bufferX, bufferY) == true)
                {
                    bufferX--;
                }
            }
        }
    }
}
