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
        UserInput input;

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
        public Player(Map map, UserInput input)
        {
            this.map = map;
            this.input = input;
        }
        
        public void Update()
        {           
            Health();
            Input();
        }

        public void Draw()
        {
            whereIs(playerX, playerY, "X");
        }

        public void Health()
        {

        }
        public void Input()
        {
            previousPlayerX = playerX;
            previousPlayerY = playerY;
            if (input.playerInput == "W")
            {
                playerY--;
            }
            if (input.playerInput == "A")
            {
                playerX--;
            }
            if (input.playerInput == "S")
            {
                playerY++;
            }
            if (input.playerInput == "D")
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
