using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Player : Character
    {
        
        Map map;
        public ConsoleKeyInfo KeyInfo;

        public int health = 100;
        public int shield = 50;

        public int playerX = 7;
        public int playerY = 4;

        public int previousPlayerX;
        public int previousPlayerY;

        public int hasKey = 0;


        //public Player() // constructor
        //{
        //    Console.WriteLine("Player class instantiated...");
        //    Console.ReadKey();
        //}
        public Player(Map map)
        {
            this.map = map;
        }
        
        public void Update()
        {
            Position(playerX, playerY, "X");
            Health();
        }

        public void Health()
        {

        }
        public void Move()
        {
            previousPlayerX = playerX;
            previousPlayerY = playerY;
            KeyInfo = Console.ReadKey(true);
            if (KeyInfo.Key == ConsoleKey.W)
            {
                playerY--;
            }
            if (KeyInfo.Key == ConsoleKey.A)
            {
                playerX--;
            }
            if (KeyInfo.Key == ConsoleKey.S)
            {
                playerY++;
            }
            if (KeyInfo.Key == ConsoleKey.D)
            {
                playerX++;
            }
            bool wallchecker = map.WallChecker(playerX, playerY);

            if (wallchecker)
            {
                playerX = previousPlayerX;
                playerY = previousPlayerY;
            }
            if (hasKey == 0 && map.publicMap[playerY,playerX] == "I")
            {
                playerX = previousPlayerX;
                playerY = previousPlayerY;
            }

           
        }

    }
}
