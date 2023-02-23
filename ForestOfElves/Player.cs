﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Player : Character
    {
        Map map = new Map();

        
        public int playerX = 3;
        public int playerY = 4;

        public int previousPlayerX;
        public int previousPlayerY;


        public void Update()
        {         
            Position(playerX, playerY, "X");
            Move();
        }

        public void Move()
        {               
            previousPlayerX = playerX;
            previousPlayerY = playerY;
           
            Program coords = new Program();
            if (coords.KeyInfo.Key == ConsoleKey.W)
            {
                playerY--;
            }
            if (coords.KeyInfo.Key == ConsoleKey.A)
            {
                playerX--;
            }
            if (coords.KeyInfo.Key == ConsoleKey.S)
            {
                playerY++;
            }
            if (coords.KeyInfo.Key == ConsoleKey.D)
            {
                playerX++;
            }
            bool wallchecker = map.WallChecker(playerX, playerY);
            
            if (wallchecker)
            {
                playerX = previousPlayerX;
                playerY = previousPlayerY;
            }
           
        }

    }
}
