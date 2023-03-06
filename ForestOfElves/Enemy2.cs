using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Enemy2 : Character
    {
        Map map;
        //Player player = new Player(); // a new player! uh-oh!!
        Player player; // reference to the player
        static Random random = new Random();

        public string sprite = "D";

        public int enemyX = 12;
        public int enemyY = 12;

        public int previousEnemyX;
        public int previousEnemyY;

        public bool dead;
        public bool attacked;

        public Enemy2(Player player, Map map) // constructor
        {
            this.player = player;
            this.map = map;
        }

        public void Update()
        {
            EnemyAttacked();
            whereIs(enemyX, enemyY, sprite);
            if (attacked)
            {
                Attack();
            }
            else
            {
                Move();                
            }

        }
        public void Move()
        {
            previousEnemyX = enemyX;
            previousEnemyY = enemyY;
            int move = random.Next(1, 3);
            if (move == 1)
            {
                enemyY--;
            }
            if (move == 2)
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
            if (player.playerX == enemyX && player.playerY == enemyY)
            {
                attacked = true;
            }
        }
        public void Attack()
        {

            sprite = " ";
            return;

        }
        public void EnemyKilled()
        {
            if (player.playerX == enemyX && player.playerY == enemyY)
            {
                attacked = true;
            }
        }
    }
}
