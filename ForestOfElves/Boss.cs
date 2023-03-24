using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Boss : Enemy
    {
        Map map;
        Player player;
        Random random;

        public Boss(Map map, Random random, Player player) : base(map, random, player)
        {
            this.map = map;
            this.random = random;
            this.player = player;
            UserInput input = new UserInput();
        }
        public override void OnStart()
        {
            bossIsDead = false;
            health = 500;
            sprite = "B";
            decay = 5;
            howManyPlyrMoves = 0; // how many player moves until it can do an action
            amountLeft = howManyPlyrMoves;

            currentEnemyDamage = 100;
        }
        public override void Update()
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
                GoingTo();

                if (player.IsPlayerAt(targetPosX, targetPosY))
                {
                    Attacking();
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
                bossIsDead = true;
            }
            return;
        }
        public override void Attacking()
        {
            player.TakeDamage(currentEnemyDamage);
        }
    }
}
