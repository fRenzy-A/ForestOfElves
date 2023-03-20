using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Enemy : Character
    {
        Map map;
        //Player player = new Player(); // a new player! uh-oh!!
        Player player; // reference to the player
        static Random random = new Random();

        public string sprite = "G";

        public int enemyX = 12;
        public int enemyY = 12;

        public int health = 5;

        public int previousEnemyX;
        public int previousEnemyY;

        public bool dead;
        public bool inBattle = false;
        public bool attacked;
        public bool attackingSmall;
        public bool attackingLarge;

        public Enemy(Player player, Map map) // constructor
        {
            this.player = player;
            this.map = map;
        }

        public void Update()
        {
            attacked = false;

            IsPlayerNear();
            if (inBattle)
            {
                IsBeingAttacked();
                Attacking(6);
            }
            else Move();
        }
        public void Draw()
        {

            whereIs(enemyX, enemyY, sprite);

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
                health--;
            }
            if (health == 0)
            {
                sprite = " ";
                inBattle = false;
            }
        }

        
        public void Attacking(int attackChanceMax)
        {
            int howMuchDamage = random.Next(1, attackChanceMax);

            switch (howMuchDamage)
            {
                case 3:
                    attackingLarge = true;
                    break;
                case 4:
                    attackingSmall = true;
                    break;
            }
        }
        public void IsPlayerNear()
        {
            int nearUp = enemyY - 1;
            int nearDown = enemyY + 1;
            int nearLeft = enemyX - 1;
            int nearRight = enemyX + 1;

            if (enemyX == player.playerX && nearUp == player.playerY)
            {
                inBattle = true;
            }
            else if (enemyX == player.playerX && nearDown == player.playerY)
            {
                inBattle = true;
            }
            else if (nearLeft == player.playerX && enemyY == player.playerY)
            {
                inBattle = true;
            }
            else if (nearRight == player.playerX && enemyY == player.playerY)
            {
                inBattle = true;
            }
            
        }

    }
}
