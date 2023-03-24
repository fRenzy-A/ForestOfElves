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
        public ShieldParts(Player player) : base(player)
        {
            this.player = player;
            sprite = "S";
        }

        public override void Update()
        {
            if (taken)
            {
                return;
            }
            else IsTaken();
        }
        public override void Draw()
        {
            WhereIs(x, y, sprite);
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
