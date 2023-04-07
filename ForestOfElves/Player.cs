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

        public int shield;
        public int usePot;
        public int usePart;

        public bool attacking;

        public int currentplayerDamage;

        public int howManyPotions;
        public int howManyShields;
        public int keyParts;

        public bool killedBoss;

        public bool playerDied;

        public Player(Map map, UserInput input,Renderer renderer) : base(renderer)
        {
            
            this.map = map;
            this.input = input; 
        }

        public void OnStart()
        {
            sprite = Settings.playerSprite;
            health = Settings.playerHealth;
            shield = Settings.playerShield;
            usePot = Settings.howMuchWillPotionsGive;
            usePart = Settings.howMuchWillShieldsGive;
            x = Settings.playerPositionX;
            y = Settings.playerPositionY;
            currentplayerDamage = Settings.playerDamage;
            howManyPotions = 0;
            howManyShields = 0;
            killedBoss = false;
            playerDied = false;
        }
        public void Update(EnemyManager enemyManager)
        {
            attacking = false;
            SetTargetPositionOrUseItems();//where movement is calculated and or if player uses an item


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
                else
                {
                    x = targetPosX;
                    y = targetPosY;
                } // in order to move in invisible corpses
            }

            else
            {
                x = targetPosX;
                y = targetPosY;
            } //when all above are false
        }

        public void Draw()
        {
            WhereIs(x, y, sprite);
        }
        public void TakeDamage(int enemyDamage)
        {
            if (shield < enemyDamage) //spillover
            {
                health = (health + shield) - enemyDamage;
                shield = 0;
            }
            else if (shield == 0)
            {
                health -= enemyDamage;
            }
            else shield -= enemyDamage;

            if (health <= 0)
            {
                health = 0;
                playerDied = true;
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
        public void UsePotionAndHeal(int hpUP)
        {
            int currentHealth = health;
            if (howManyPotions == 0)
            {
                return;
            }
            else
            {
                if(health != Settings.playerHealth) howManyPotions--;
                currentHealth += hpUP;
                if (currentHealth > Settings.playerHealth)
                {
                    currentHealth = Settings.playerHealth;
                }
                health = currentHealth;
            }
        }
        public void UsePartsAndRepair(int shUP)
        {
            int currentShields = shield;
            if (howManyShields == 0)
            {
                return;
            }
            else
            {
                if (shield != Settings.playerShield) howManyShields--;
                currentShields += shUP;
                if (currentShields > Settings.playerShield)
                {
                    currentShields = Settings.playerShield;
                }
                shield = currentShields;
            }
        }
        public void SetTargetPositionOrUseItems()
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
                UsePotionAndHeal(usePot);
                dx = 0;
                dy = 0;
            }
            if (input.USEPART)
            {
                UsePartsAndRepair(usePart);
                dx = 0;
                dy = 0;
            }
            targetPosX = x + dx;
            targetPosY = y + dy;
        }

   
    }
}
