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
        Random random;
        public Grunt(Player player, Map map, Random random) : base(player, map)
        {
            this.random = random;
            this.player = player;
            sprite = "G";
            enemyX = 12;
            enemyY = 12;
            howManyPlyrMoves = 2;
            amountLeft = howManyPlyrMoves;
            currentAttackChance = 6;
            this.random = random;
        }
        public override void Update()
        {

            
            attacked = false;

            if (player.inBattle)
            {
                
                IsBeingAttacked();
                Attacking(currentAttackChance);
                
            }
            else
            {
                amountLeft -= 1;
                if (amountLeft == 0)
                {
                    Move();
                    amountLeft = howManyPlyrMoves;
                }
            }
            Defeated();

        }
    }
}
