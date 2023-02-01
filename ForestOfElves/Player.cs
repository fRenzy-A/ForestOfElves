using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Player
    {
        static int x;
        static int y;

        public void PlayerA()
        {
            Position(x, y);
            PlayerUpdate();
        }

        static void Position(int x, int y)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write("X");
        }
        static void PlayerUpdate()
        {
            ConsoleKeyInfo KeyInfo;
            KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.W)
            {
                y--;
            }
            if (KeyInfo.Key == ConsoleKey.A)
            {
                x--;
            }
            if (KeyInfo.Key == ConsoleKey.S)
            {
                y++;
            }
            if (KeyInfo.Key == ConsoleKey.D)
            {
                x++;
            }
            Console.Clear();
        }
    }
}
