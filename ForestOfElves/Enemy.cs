using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Enemy
    {
        Map map;
        //Player player = new Player(); // a new player! uh-oh!!
        Player player; // reference to the player
        static Random random = new Random();

        public string sprite;

        public static int enemyX;
        public static int enemyY;

        public int health = 100;

        public int previousEnemyX;
        public int previousEnemyY;

        public bool attacked;
        
        public int currentEnemyDamage;
        public int currentAttackChance;

        public int howManyPlyrMoves;
        public int amountLeft;
        public Enemy(Player player, Map map) // constructor
        {
            this.player = player;
            this.map = map;   
        }

        public virtual void Update()
        {

        }
          
        public void Draw()
        {
            whereIs(enemyX, enemyY, sprite);
        }
        public void whereIs(int x, int y, string character)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(character);
        }
        public void Move()
        {
            previousEnemyX = enemyX;
            previousEnemyY = enemyY;
            int move = random.Next(1, 5);
            if (move == 1)
            {
                enemyX--;
            }
            if (move == 2)
            {
                enemyX++;
            }
            if (move == 3)
            {
                enemyY--;
            }
            if (move == 4)
            {
                enemyY++;
            }
            bool wallchecker = map.WallChecker(enemyX, enemyY);
            if (wallchecker)
            {
                enemyX = previousEnemyX;
                enemyY = previousEnemyY;
            }

        }

        public void IsBeingAttacked()
        {           
            if (player.attacking)
            {
                health-= player.currentplayerDamage;
            }
            
        } 
        public void Attacking(int attackChanceMax)
        {
            
            int damageChance = random.Next(1, attackChanceMax);

            if (damageChance == 1)
            {
                currentEnemyDamage = 10;
            }
            else currentEnemyDamage = 0;

        }
        
        public void Defeated()
        {
            if (health == 0)
            {
                sprite = "";
                player.inBattle = false;
                return;
            }
            
        }
    }
}
