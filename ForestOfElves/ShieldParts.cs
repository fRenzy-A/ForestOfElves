using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class ShieldParts : Items
    {
        Player player;
        public ShieldParts(Player player, Renderer renderer) : base(player, renderer)
        {
            this.player = player;
            sprite = Settings.shieldSprite;
        }

        public override void Update()
        {
            if (taken)
            {
                return;
            }
            else IsTaken();
        }
        public override void IsTaken()
        {
            if (player.IsPlayerAt(x, y))
            {
                player.howManyShields++;
                sprite = "";
                taken = true;
            }
        }
    }
}
