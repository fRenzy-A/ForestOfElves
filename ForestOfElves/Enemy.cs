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
        Player player = new Player();
        static Random random = new Random();
       
        public string sprite = "A"; 

        public int enemyX = 5;
        public int enemyY = 6;

        public int previousEnemyX;
        public int previousEnemyY;

        public bool dead;
        public void Update()
        {
            Position(enemyX, enemyY, sprite);
            
            Move();
        }
        public void Move()
        {
            previousEnemyX = enemyX;
            previousEnemyY = enemyY;
            int move = random.Next(1, 5);
            if (dead == false)
            {
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
            else return;
            
        }
        
        
    }
}
