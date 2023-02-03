using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Enemy
    {
        static Random random = new Random();

        static int currentX = 5;
        static int currentY = 5;

        public int bufferX = currentX;
        public int bufferY = currentY;
        public void EnemyManager()
        {
            Position(currentX,currentY);
            EnemyUpdate();
        }
        static void Position(int x, int y)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write("A");
        }
        public void EnemyUpdate()
        {
            Map map = new Map();
            int move = random.Next(1, 5);
            if (move == 1)
            {
                bufferY--;
                if (map.WallChecker(bufferX, bufferY) == false)
                {
                    currentY = bufferY;
                }
                else if (map.WallChecker(bufferX, bufferY) == true)
                {
                    bufferY++;
                }
            }
            if (move == 2)
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
            if (move == 3)
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
            if (move == 4)
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
