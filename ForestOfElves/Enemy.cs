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

        public int currentX;
        public int currentY;

        public int bufferX;
        public int bufferY;
        public void EnemyManager(int hp)
        {
            bufferX = currentX;
            bufferY = currentY;
            Position(currentX,currentY, hp);
            EnemyUpdate();
        }
        static void Position(int x, int y, int damage)
        {
            CharacterManager health = new CharacterManager();
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            string str = "A";
            Console.Write(str);
            if (damage == 0)
            {
                str.Remove(0);
            }
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
