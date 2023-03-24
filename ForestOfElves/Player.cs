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
        Random random;
        //Enemy enemy;

        public int health;
        public int shield;
        public int usePot;
        public int usePart;


        public int x = 10;
        public int y = 5;
        
        //deltas
        public int dx;
        public int dy;

        public int targetPosX;
        public int targetPosY;  


        public bool attacking;

        public int currentplayerDamage = 50;

        public int howManyPotions;
        public int howManyShields;
        public int keyParts;


        public Player(Map map, UserInput input, Random random)
        {
            this.map = map;
            this.input = input; 
            this.random = random;  
        }

        public void OnStart()
        {
            health = 10;
            shield = 0;
            usePot = 50;
            usePart = 25;
            x = 10;
            y = 5;
            currentplayerDamage = 50;
        }
        public void Update(EnemyManager enemyManager)
        {
            attacking = false;
            Input();//where movement is calculated
            
            if (map.IsWallAt(targetPosX, targetPosY)) return;//checks for walls
            if (keyParts < 2)//checks to see how many keys player has
            {
                if (map.IsDoorAt(targetPosX, targetPosY)) return;//checks for doors
            }
            

            if (enemyManager.IsEnemyAt(targetPosX, targetPosY))//checks for enemies
            {
                Enemy enemy = enemyManager.GetEnemyAt(targetPosX, targetPosY); 
                if (!enemy.dead) // if enemy isnt dead
                {
                    Attack(enemy);
                }
                else MovePlayer(); // in order to move in invisible corpses
            }

            else MovePlayer();//when all above are false
        }

        public void Draw()
        {
            WhereIs(x, y, "X");
        }
        public void TakeDamage(int enemyDamage)
        {
            if (shield < enemyDamage) //spillover
            {
                health = (health + shield) - enemyDamage;
                shield = 0;

            }
            else shield -= enemyDamage;
            if (shield == 0)
            {
                health -= enemyDamage;
            }
        }

        public bool IsPlayerAt(int enX, int enY)
        {
            if (x == enX && y == enY)
            {
                return true;
            }
            return false;
        }

        public void Attack(Enemy enemy)
        {
            enemy.TakeDamage();
        }
        public void UsePotAndHeal(int howMuch,int hp)
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
                    health = 100;
                }
            }
        }
        public void UsePartsAndRepair(int howMuch, int sh)
        {
            if (howManyShields == 0)
            {
                return;
            }
            else
            {
                howManyShields--;
                sh += howMuch;
                if (shield < 50)
                {
                    shield = 50;
                }
            }
        }
        public void Input()
        {
            if (input.UP)
            {
                dx = 0;
                dy = -1;
            }
            if (input.LEFT)
            {
                dx = -1;
                dy = 0;
            }
            if (input.DOWN)
            {
                dx = 0;
                dy = 1;     
            }
            if (input.RIGHT)
            {
                dx = 1;
                dy = 0;
            }
            if (input.USEPOT)
            {
                UsePotAndHeal(usePot, health);
            }
            if (input.USEPART)
            {
                UsePartsAndRepair(usePart, shield);
            }
            if (input.SPACE)
            {
                health = -20;
            }
            targetPosX = x + dx;
            targetPosY = y + dy;
        }
        public void MovePlayer()
        {
            x = targetPosX;
            y = targetPosY;
        }

        public bool PlayerDied()
        {
            if (health <= 0)
            {
                return true;
            }
            else return false;
        }
    }
}
