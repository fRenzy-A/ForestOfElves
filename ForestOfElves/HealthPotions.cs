using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class HealthPotions : Items
    {
        Player player;
        public HealthPotions(Player player, Renderer renderer) : base(player, renderer)
        {
            this.player = player;
            sprite = 'H';
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
            WhereIs(x,y,sprite);
        }
        public override void IsTaken()
        {
            if (player.IsPlayerAt(x, y))
            {
                player.howManyPotions++;
                sprite = ' ';
                taken = true;
            }
        }
    }
}
