using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Tank : Enemy
    {
        Map map;
        Player player;
        Random random;
        public Tank(Map map, Random random, Player player, Renderer renderer) : base(map, random, player, renderer)
        {
            this.map = map;
            this.random = random;
            this.player = player;
        }
        public override void OnStart()
        {
            health = Settings.tankHealth;
            sprite = Settings.tankSprite;
            decay = 5;
            howManyPlyrMoves = 7; // how many player moves until it can do an action
            amountLeft = howManyPlyrMoves;

            currentEnemyDamage = Settings.tankDamage;
        }
        public override void Update()
        {
            base.Update();
        }

    }
}
