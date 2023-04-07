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

        public Boss(Map map, Random random, Player player, Renderer renderer) : base(map, random, player, renderer)
        {
            this.map = map;
            this.random = random;
            this.player = player;
        }
        public override void OnStart()
        {
            bossIsDead = false;
            health = Settings.BOSSHealth;
            sprite = Settings.BOSSSprite;
            decay = 5;
            amountLeft = howManyPlyrMoves;

            currentEnemyDamage = Settings.BOSSDamage;
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
                SetTargetPosition();

                if (player.IsPlayerAt(targetPosX, targetPosY))
                {
                    Attacking();
                }

            }

        }

        public override void TakeDamage()
        {
            health -= player.currentplayerDamage;

            if (health <= 0)
            {
                sprite = Settings.DEADSprite;
                player.killedBoss = true;
                dead = true;
            }
            return;
        }
    }
}
