using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Program
    {
        public ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

        static void Main(string[] args)
        {           
            GameManager gameManager = new GameManager();
            gameManager.GameUpdate();
            
        }
        
    }
}
