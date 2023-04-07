using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Grunt : Enemy
    {
        Map map;
        Player player;
        Random random;
 
        public Grunt(Map map,Random random,Player player, Renderer renderer) : base(map, random,player, renderer) 
        {        
            this.map = map;
            this.random = random;
            this.player = player;
        }
        public override void OnStart()
        {
            health = Settings.gruntHealth;
            sprite = Settings.gruntSprite;
            decay = 5;
            howManyPlyrMoves = 2; // how many player moves until it can do an action
            amountLeft = howManyPlyrMoves;

            currentEnemyDamage = Settings.gruntDamage;
        }
        public override void Update()
        {
            base.Update();
        }

    }
}
