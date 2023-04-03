using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class FastGrunt : Enemy
    {
        Map map;
        Player player;
        Random random;
        public FastGrunt(Map map, Random random, Player player, Renderer renderer) : base(map, random, player, renderer)
        {

            this.map = map;
            this.random = random;
            this.player = player;
            UserInput input = new UserInput();
            
        }
        public override void OnStart()
        {
            health = 50;
            sprite = "F";
            howManyPlyrMoves = 1;
            amountLeft = howManyPlyrMoves;
            currentEnemyDamage = 5;
            decay = 5;
        }
        public override void Update()
        {
            attacked = false;
            //IsPlayerNear();
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
                    GoingTo();

                    if (map.IsWallAt(targetPosX, targetPosY)) return;
                    //if ()

                    if (player.IsPlayerAt(targetPosX, targetPosY))
                    {
                        Attacking();
                    }
                    else
                    {
                        Move();
                    }
                    amountLeft = howManyPlyrMoves;
                }

            }

        }
        public override void Draw()
        {
            WhereIs(x, y, sprite);
        }
        public override void GoingTo()
        {

            int move = random.Next(1, 5);
            if (move == 1)
            {
                dx = 0;
                dy = -1;
                //ndy = y - 1; 
            }
            if (move == 2)
            {
                dx = -1;
                dy = 0;
                //ndx = x - 1;
            }
            if (move == 3)
            {
                dx = 0;
                dy = 1;
                //dy = y + 1;
            }
            if (move == 4)
            {
                dx = 1;
                dy = 0;
                //dx = x + 1;
            }
            targetPosX = x + dx;
            targetPosY = y + dy;
        }
        public override void Move()
        {
            x = targetPosX;
            y = targetPosY;
        }
        public override void TakeDamage()
        {
            health -= player.currentplayerDamage;

            if (health <= 0)
            {
                sprite = "k";
                dead = true;
            }
            return;
        }
        public override void Attacking()
        {

            
            player.TakeDamage(currentEnemyDamage);
        }
    }
}

