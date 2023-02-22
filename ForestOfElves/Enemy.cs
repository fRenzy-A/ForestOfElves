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
        Map map = new Map();
        
        static Random random = new Random();

        static string sprite = "A"; 

        public int enemyX = 6;
        public int enemyY = 6;

        public int previousEnemyX;
        public int previousEnemyY;

        public int currentEnemyX;
        public int currentEnemyY;

        protected bool dead = false;
        public void Update()
        {
            currentEnemyX = enemyX;
            currentEnemyY = enemyY;
            Position(enemyX, enemyY, sprite);
            
            Move();
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
        public void Attacked()
        {
            Player player = new Player();
            if (player.currentPlayerX == currentEnemyX && player.currentPlayerY == currentEnemyY)
            {
                sprite = " ";
            }
        }
    }
}
