﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public string playerInput;

        public void Input()
        {

            UP = false;
            DOWN = false;
            LEFT = false;
            RIGHT = false;
            ConsoleKeyInfo playerInput = Console.ReadKey(true);



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
            }
            
        }
    }
}
