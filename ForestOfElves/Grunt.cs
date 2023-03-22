using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Grunt : Enemy
    {
        Player player;
        //Random random;
        Map map;
        public Grunt(Player player, Map map) : base(player,map) 
        {
            //this.random = random;
            this.player = player;
            sprite = "G";
            x = 12;
            y = 12;
            howManyPlyrMoves = 2;
            amountLeft = howManyPlyrMoves;
            currentAttackChance = 6;
            //this.random = random;
        }
        public override void Update()
        {
            attacked = false;
            //IsPlayerNear();
            amountLeft -= 1;
            if (dead)
            {
                return;
            }
            else
            {
                if (amountLeft == 0)
                {
                    Move();

                    amountLeft = howManyPlyrMoves;
                }
                if (x == player.x && y == player.y)
                {
                    Attacking();
                }
                if (attacked)
                {
                    TakeDamage();
                }
            }
            
            
            

        }
        public override void IsPlayerNear()
        {
            int nearUp = y - 1;
            int nearDown = y + 1;
            int nearLeft = x - 1;
            int nearRight = x + 1;

            if (nearLeft == player.x && y == player.y || nearRight == player.x && y == player.y || x == player.x && nearUp == player.y || nearDown == player.y && x == player.x)
            {
            }
        }
        public override void TakeDamage()
        {
            health -= player.currentplayerDamage;

            if (health <= 0)
            {
                sprite = "k";
                dead = true;
                return;
            }
        }
        public override void Attacking()
        {

            currentEnemyDamage = 10;

            player.TakeDamage(currentEnemyDamage);
            x = previousX;
            y = previousY;

        }
    }
}
