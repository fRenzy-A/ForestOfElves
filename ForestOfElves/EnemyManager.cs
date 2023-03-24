using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class EnemyManager
    {
        List<Enemy> enemies;
        Random random;
        int rndLocationX;
        int rndLocationY;
        //Enemy[] enemy = new Enemy[]; 

        public EnemyManager(Map map, Random random, Player player)
        {
            enemies = new List<Enemy>();
            this.random = random;

            // setting up batch of enemies in specific locations
            for (int i = 0; i < 8; i++)
            {
                rndLocationX = random.Next(25, 45);
                rndLocationY = random.Next(6, 14);
                enemies.Add(new Grunt(map, random, player) { x = rndLocationX, y = rndLocationY });
            }
            for (int i = 0; i < 12; i++)
            {
                rndLocationX = random.Next(6, 59);
                rndLocationY = random.Next(35, 41);
                enemies.Add(new Grunt(map, random, player) { x = rndLocationX, y = rndLocationY });
            }
            for (int i = 0; i < 5; i++)
            {
                rndLocationX = random.Next(76, 94);
                rndLocationY = random.Next(3, 12);
                enemies.Add(new Grunt(map, random, player) { x = rndLocationX, y = rndLocationY });
            }
            for (int i = 0; i < 5; i++)
            {
                rndLocationX = random.Next(25, 45);
                rndLocationY = random.Next(16, 22);
                enemies.Add(new FastGrunt(map, random, player) { x = rndLocationX, y = rndLocationY });
            }
            for (int i = 0; i < 3; i++)
            {
                rndLocationX = random.Next(82, 88);
                rndLocationY = random.Next(23, 31);
                enemies.Add(new Tank(map, random, player) { x = rndLocationX, y = rndLocationY });
            }
            //31,29 first key lcoation | 85, 40 second key location | 83,27 tanks location | 69,10 boss location
        }
        public void OnStart()
        {           
            foreach (Enemy enemy in enemies)
            {                
                enemy.OnStart();
            }
        }

        public void Update()
        {            
            foreach (Enemy enemy in enemies)
            {
                enemy.Update();           
            }          
        }
        public bool IsEnemyAt(int playerX, int playerY)
        {
            foreach (Enemy enemy in enemies)
            {
                if (playerX == enemy.x && playerY == enemy.y)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsFellowEnemyAt(int fellowX, int fellowY) // making sure no enemies bump into each other ****UNUSED****
        {
            foreach (Enemy enemy in enemies)
            {
                if (fellowX == enemy.x && fellowY == enemy.y)
                {
                    return true;
                }
            }
            return false;
        }

        public Enemy GetEnemyAt(int playerX, int playerY)
        {
            foreach (Enemy enemy in enemies)
            {
                if (playerX == enemy.x && playerY == enemy.y)
                {
                    return enemy;   
                }                
            }
            
            return null;
        }
        public void Draw()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.Draw();
            }
        }



    }
}
