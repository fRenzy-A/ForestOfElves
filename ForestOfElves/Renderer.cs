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
        public Renderer()
        {
            //this.map = map;
            //this.character = character;
            
        }
        public void RenderGame(string Character, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Character);
            
            /*foreach (char[] c in drawData)
            {         
                foreach (char c2 in c)
                {
                    Console.Write(c2);
                }
                Console.WriteLine();
            }*/
 
        }


    }
}
