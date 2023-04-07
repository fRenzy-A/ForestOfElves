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
            
        }
        public override void OnStart()
        {
            health = Settings.fastGruntHealth;
            sprite = Settings.fastGruntSprite;
            howManyPlyrMoves = 1;
            amountLeft = howManyPlyrMoves;
            currentEnemyDamage = Settings.fastGruntDamage;
            decay = 5;
        }
        public override void Update()
        {
            base.Update();
        }


    }
}

