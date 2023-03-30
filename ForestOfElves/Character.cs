using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Character
    {
        public int x { get; set; }
        public int y { get; set; }

        public int health;
        public int dx;
        public int dy;
        public int targetPosX;
        public int targetPosY;

        public char sprite;
         
        public void WhereIs(int x, int y, char character)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(character);
        }
    }
}
