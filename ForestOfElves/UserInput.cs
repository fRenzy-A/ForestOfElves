using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class UserInput
    {

        public bool UP;
        public bool DOWN;
        public bool LEFT;
        public bool RIGHT;
        public bool USEPOT;
        public bool USEPART;
        public bool ENTER;


        public void Input()
        {
            ConsoleKeyInfo playerInput = Console.ReadKey(true);
            UP = false;
            DOWN = false;
            LEFT = false;
            RIGHT = false;
            USEPOT = false;
            USEPART = false;
            ENTER = false;
            



            switch (playerInput.Key)
            {
                case ConsoleKey.W:
                    UP = true;
                    break;
                case ConsoleKey.S:
                    DOWN = true;
                    break;
                case ConsoleKey.A:
                    LEFT = true;
                    break;
                case ConsoleKey.D:
                    RIGHT = true;
                    break;
                case ConsoleKey.J:
                    USEPOT = true;
                    break;
                case ConsoleKey.L:
                    USEPART = true;
                    break;
                case ConsoleKey.Enter:
                    ENTER = true;
                    break;
            }
            
        }
    }
}
