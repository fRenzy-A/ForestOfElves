using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Player : Character
    {
        
        Map map;
        UserInput input;
        //Enemy enemy;

        public int health = 100;
        public int shield = 50;
        public int usePot = 50;
        public int usePart = 25;


        public int x = 7;
        public int y = 4;

        public int dx;
        public int dy;

        public int targetPosX;
        public int targetPosY;  

        public int enemyX;
        public int enemyY;

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


        public Player(Map map, UserInput input)
        {
            this.map = map;

            this.input = input; 
        }

        public void Update(EnemyManager enemyManager)
        {
            attacking = false;
            Input();

            if (map.WallChecker(targetPosX, targetPosY)) return;

            if (enemyManager.IsEnemyAt(targetPosX, targetPosY))
            {
                Enemy enemy = new EnemyManager(map).GetEnemyAt(targetPosX, targetPosY); 
                
                enemy.TakeDamage();
                enemy.attacked = true;
            }

            else Moving();
        }

        public void Draw()
        {
            whereIs(x, y, "X");
        }
        public void TakeDamage(int enemyDamage)
        {
            health -= enemyDamage;
        }

        public bool IsPlayerAt(int enX, int enY)
        {
            if (x == enX && y == enY)
            {
                return true;
            }
            return false;
        }

        public void Attack()
        {            
            
        }
        public void UsePotAndHeal(int howMuch,int hp)
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
                    hp += howMuch;
                    if (health < 100)
                    {
                        hp = 100;
                    }
                }                
            }
        }
        public void UsePartsAndRepair(int howMuch, int sh)
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
                    if (sh < 50)
                    {
                        sh = shield;
                    }
                }                
            }
        }
        public void Input()
        {
            if (input.UP)
            {
                dx = 0;
                dy = -1;
                //ndy = y - 1; 
            }
            if (input.LEFT)
            {
                dx = -1;
                dy = 0;
                //ndx = x - 1;
            }
            if (input.DOWN)
            {
                dx = 0;
                dy = 1;     
                //dy = y + 1;
            }
            if (input.RIGHT)
            {
                dx = 1;
                dy = 0;
                //dx = x + 1;
            }
            targetPosX = x + dx;
            targetPosY = y + dy;
        }
        public void Moving()
        {
            x = targetPosX;
            y = targetPosY;
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
