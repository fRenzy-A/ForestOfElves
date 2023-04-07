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
        Player player;
        Random random;
        Renderer renderer;
        
        public int decay;

        public bool attacked;
        
        public int currentEnemyDamage; // how many player moves until it can do an action

        public int howManyPlyrMoves;
        public int amountLeft;

        public bool dead;

        public bool bossIsDead;

        public Enemy(Map map, Random random, Player player, Renderer renderer) : base (renderer)// constructor
        {
            this.map = map;
            this.player = player;
            this.random = random;
        }
        public virtual void OnStart()
        {

        }
        public virtual void Update()
        {
            attacked = false;
            amountLeft -= 1;
            if (dead)
            {
                decay--;
                if (decay == 0)
                {
                    sprite = "";
                    return;
                }
            }
            else
            {
                if (amountLeft == 0)
                {
                    SetTargetPosition();

                    if (player.IsPlayerAt(targetPosX, targetPosY))
                    {
                        Attacking();
                    }
                    else
                    {
                        x = targetPosX;
                        y = targetPosY;

                        if (map.IsWallAt(x, y)) // checks for walls. reverts the enemy position when its on top of a wall
                        {
                            x = targetPosX - dx;
                            y = targetPosY - dy;
                        }
                    }
                    amountLeft = howManyPlyrMoves;
                }
            }
        }
        public void Draw()
        {
            WhereIs(x, y, sprite);
        }
        public void SetTargetPosition() //Where does it want to move
        {
            int move = random.Next(1, 5);
            if (move == 1)
            {
                dx = 0;
                dy = -1;
            }
            if (move == 2)
            {
                dx = -1;
                dy = 0;
            }
            if (move == 3)
            {
                dx = 0;
                dy = 1;
            }
            if (move == 4)
            {
                dx = 1;
                dy = 0;
            }
            targetPosX = x + dx;
            targetPosY = y + dy;
        }

        public virtual void TakeDamage()
        {
            health -= player.currentplayerDamage;

            if (health <= 0)
            {
                sprite = Settings.DEADSprite;
                dead = true;
            }
            return;
        } 
        public virtual void Attacking()
        {
            player.TakeDamage(currentEnemyDamage);
        }
        

    }
}
