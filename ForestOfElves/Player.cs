using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Player : Character
    {
        public int x;
        public int y;
        public void PlayerManager(int positionX, int positionY)
        {         
            x = positionX;
            y = positionY;
            Position(x, y, "X");
            PlayerUpdate();
        }
        
        void PlayerUpdate()
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
