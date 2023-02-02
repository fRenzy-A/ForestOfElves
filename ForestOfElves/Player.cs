using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Player
    {
        static int futurex;
        static int futurey;

        static int currentx;
        static int currenty;
        public void PlayerA()
        {
            Position(currentx, currenty);
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
                currenty--;
            }
            if (KeyInfo.Key == ConsoleKey.A)
            {
                currentx--;
            }
            if (KeyInfo.Key == ConsoleKey.S)
            {
                currenty++;
            }
            if (KeyInfo.Key == ConsoleKey.D)
            {
                currentx++;
            }
            Console.Clear();
        }
    }
}
