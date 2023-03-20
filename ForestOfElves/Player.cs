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

        public bool attacking;


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
        
        public void Update(bool enemyAttacked)
        {
            attacking = false;
            if (enemyAttacked)
            {
                Attacking();
            }
            else Moving();

        }

        public void Draw()
        {
            whereIs(playerX, playerY, "X");
        }

        public void Attacked()
        {
            if enemy.attacking
        }
        public void Moving()
        {
            previousPlayerX = playerX;
            previousPlayerY = playerY;
            if (input.UP)
            {
                playerY--;
            }
            if (input.LEFT)
            {
                playerX--;
            }
            if (input.DOWN)
            {
                playerY++;
            }
            if (input.RIGHT)
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
        public void Attacking()
        {
            if (input.UP)
            {
                attacking = true;
            }
            if (input.LEFT)
            {
                attacking = true;
            }
            if (input.DOWN)
            {
                attacking = true;
            }
            if (input.RIGHT)
            {
                attacking = true;
            }
        }
    }
}
