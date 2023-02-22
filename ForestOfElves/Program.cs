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
        static void Main(string[] args)
        {           
            GameManager gameManager = new GameManager();
            Character character = new Character();
            Player player = new Player();
            Enemy enemy = new Enemy();
            Map map = new Map();

            gameManager.GameUpdate();
            
        }
        public ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
    }
}
