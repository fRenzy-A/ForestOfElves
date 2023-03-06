using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class UserInput
    {
        

        public string playerInput;

        public void Input()
        {
            ConsoleKeyInfo ConsoleKey = Console.ReadKey(true);
            playerInput = ConsoleKey.ToString();
        }
    }
}
