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
       
        public string sprite = "A"; 

        public int enemyX = 5;
        public int enemyY = 6;

        public int previousEnemyX;
        public int previousEnemyY;

        public bool dead;
        public bool attacked;

        public Enemy(Player player, Map map) // constructor
        {
            this.player = player;
            this.map = map;
        }

        public void Update()
        {
            //EnemyKilled();
            EnemyAttacked();
            if (dead == false)
            {
                Position(enemyX, enemyY, sprite);
                if (attacked)
                {
                    return;
                }
                else
                {
                    attacked = false;
                    Move();
                }
                    

            }
            else return;
           
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
        public void EnemyAttacked()
        {
            if (player.futurePlayerX == enemyX && player.futurePlayerY == enemyY)
            {
                attacked = true;
            }
            else if (player.playerX == enemyX && player.playerY == enemyX)
            {
                enemyX = previousEnemyX;
                enemyY = previousEnemyY;
                attacked = true;
            }
        }
        public void EnemyKilled()
        {
            if (player.playerX == enemyX && player.playerY == enemyY)
            {
                dead = true;
                Console.SetCursorPosition(25, 25);
                Console.WriteLine("dead");
            }
        }
    }
}
