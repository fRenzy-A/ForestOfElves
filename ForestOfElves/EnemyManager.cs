﻿using System;
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
        Map map;
        Player player;
        Renderer renderer;
        int rndLocationX;
        int rndLocationY;
        //Enemy[] enemy = new Enemy[]; 

        public EnemyManager(Map map, Random random, Player player, Renderer renderer)
        {
            enemies = new List<Enemy>();
            this.random = random;
            this.map = map;
            this.player = player;
            this.renderer = renderer;

            //31,29 first key lcoation | 85, 40 second key location | 83,27 tanks location | 69,10 boss location
        }
        public void OnStart()
        {
            // setting up batch of enemies in specific locations
            for (int i = 0; i < 8; i++)
            {
                rndLocationX = random.Next(25, 45);
                rndLocationY = random.Next(6, 14);
                enemies.Add(new Grunt(map, random, player,renderer) { x = rndLocationX, y = rndLocationY });
            }
            for (int i = 0; i < 12; i++)
            {
                rndLocationX = random.Next(6, 59);
                rndLocationY = random.Next(35, 41);
                enemies.Add(new Grunt(map, random, player, renderer) { x = rndLocationX, y = rndLocationY });
            }
            for (int i = 0; i < 5; i++)
            {
                rndLocationX = random.Next(76, 94);
                rndLocationY = random.Next(3, 12);
                enemies.Add(new Grunt(map, random, player, renderer) { x = rndLocationX, y = rndLocationY });
            }
            for (int i = 0; i < 5; i++)
            {
                rndLocationX = random.Next(25, 45);
                rndLocationY = random.Next(16, 22);
                enemies.Add(new FastGrunt(map, random, player, renderer) { x = rndLocationX, y = rndLocationY });
            }
            for (int i = 0; i < 3; i++)
            {
                rndLocationX = random.Next(82, 88);
                rndLocationY = random.Next(23, 31);
                enemies.Add(new Tank(map, random, player, renderer) { x = rndLocationX, y = rndLocationY });
            }
            enemies.Add(new Boss(map, random, player, renderer) { x = 60, y = 14 });
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

        public void DeleteAll()
        {
            enemies.Clear();
        }

    }
}
