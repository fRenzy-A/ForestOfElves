using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class KeyParts : Items
    {
        Player player;
        public KeyParts(Player player) : base(player)
        {
            this.player = player;
            sprite = "<";
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
                player.keyParts++;
                sprite = "";
                taken = true;
            }
        }
    }
}
