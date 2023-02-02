using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Player
    {
        public int currentx = 3;
        public int currenty = 3;

        public int bufferx;
        public int buffery;
  
        public void PlayerA()
        {
            Position(currentx, currenty);
        }
        static void Position(int x, int y)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write("X");
        }
        
        public void PlayerUpdate(bool playermove)
        {
            ConsoleKeyInfo KeyInfo;
            KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.W)
            {
                buffery = currenty;
                if (playermove == false)
                {
                    currenty = buffery;
                    currenty--;
                }
            }
            if (KeyInfo.Key == ConsoleKey.A)
            {
                bufferx = currentx;
                if (playermove == false)
                {
                    currentx = bufferx;
                    currentx--;
                }
            }
            if (KeyInfo.Key == ConsoleKey.S)
            {
                buffery = currenty;
                if (playermove == false)
                {
                    currenty = buffery;
                    currenty++;
                }
            }
            if (KeyInfo.Key == ConsoleKey.D)
            {
                bufferx = currentx;
                if (playermove == false)
                {
                    currentx = bufferx;
                    currentx++;
                }
            }
            Console.Clear();
            
        }
        public void PlayerMoverX()
        {

        }
        public void PayerMoveY()
        {

        }
    }
}
