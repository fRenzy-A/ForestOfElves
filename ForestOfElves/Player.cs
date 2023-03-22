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

        public int x = 7;
        public int y = 4;

        public int dx;
        public int dy;
        public int ndx;
        public int ndy;

        public int previousX;
        public int previousY;

        public int hasKey = 0;

        public bool attacking;
        public bool healing;
        public bool repairing;
        public bool blockDamage;

        public int currentplayerDamage = 50;

        public int howManyPotions;
        public int howManyShields;



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

        public void Update(int enemyX, int enemyY, Enemy enemy)
        {
            attacking = false;
            Moving();

            if (enemyX == x && enemyY == y && !enemy.dead)
            {
                Attack(enemy);
                enemy.attacked = true;
            }
        }

        public void Draw()
        {
            whereIs(x, y, "X");
        }
        public void TakeDamage(int enemyDamage)
        {
            health -= enemyDamage;
        }

        public void Attack(Enemy enemy)
        {
            
            enemy.TakeDamage();
            x = previousX;
            y = previousY;
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
        public void Input()
        {
            if (input.UP)
            {
                ndy = y - 1;
            }
            if (input.LEFT)
            {
                ndx = x - 1;
            }
            if (input.DOWN)
            {
                dy = y + 1;
            }
            if (input.RIGHT)
            {
                dx = x + 1;
            }
            dx = x + 1;
            dy = y + 1;
            ndx = x - 1;
            ndy = y - 1;
        }
        public void Moving()
        {
            previousX = x;
            previousY = y;
            

            if (input.UP)
            {
                y--;
            }
            if (input.LEFT)
            {
                x--;
            }
            if (input.DOWN)
            {
                y++;
            }
            if (input.RIGHT)
            {
                x++;
            }
            bool wallchecker = map.WallChecker(x, y);
            if (wallchecker)
            {
                x = previousX;
                y = previousY;
            }
            if (hasKey == 0 && map.publicMap[y,x] == "I")
            {
                x = previousX;
                y = previousY;
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
