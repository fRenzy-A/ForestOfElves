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
        public bool healing;
        public bool repairing;
        public bool blockDamage;

        public int currentplayerDamage = 50;

        public int howManyPotions;
        public int howManyShields;

        public bool inBattle = false;



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
            attacking = false;
            IsPlayerNear();
            if (inBattle)
            {
                IsDamaged();
                InBattle();
                UsePotAndHeal(50);
                UsePartsAndRepair(25);
            }
            else Moving();
        }

        public void Draw()
        {
            whereIs(playerX, playerY, "X");
        }
        public void IsDamaged()
        {
            health -= 10;
        }

        public void UsePotAndHeal(int howMuch)
        {
            if (healing)
            {
                if (howManyPotions == 0)
                {
                    return;
                }
                else
                {
                    howManyPotions--;
                    health += howMuch;
                }                
            }
        }
        public void UsePartsAndRepair(int howMuch)
        {
            if (repairing)
            {
                if (howManyShields == 0)
                {
                    return ;
                }
                else
                {
                    howManyShields--;
                    shield += howMuch;
                }                
            }
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
        public void IsPlayerNear()
        {
            int nearUp = playerY - 1;
            int nearDown = playerY + 1;
            int nearLeft = playerX - 1;
            int nearRight = playerX + 1;

            if (nearLeft == Enemy.enemyX && playerY == Enemy.enemyY || nearRight == Enemy.enemyX && playerY == Enemy.enemyY || playerX == Enemy.enemyX && nearUp == Enemy.enemyY || nearDown == Enemy.enemyX && playerY == Enemy.enemyY)
            {
                inBattle = true;
            }
        }
        public void InBattle()
        {
            if (input.UP)
            {
                attacking = true;
            }
            if (input.LEFT)
            {
                healing = true;
            }
            if (input.DOWN)
            {
                blockDamage = true;
            }
            if (input.RIGHT)
            {                
                repairing = true;
            }
        }
    }
}
