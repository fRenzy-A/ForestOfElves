using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Renderer
    {
        Map map;
        Character character;
        public char[][] drawData;
        public Renderer()
        {
            //this.map = map;
            //this.character = character;
            
        }
        public void RenderGame()
        {
            Console.SetCursorPosition(0, 0);
            foreach (char[] c in drawData)
            {         
                foreach (char c2 in c)
                {
                    Console.Write(c2);
                }
                Console.WriteLine();
            }
 
        }


    }
}
