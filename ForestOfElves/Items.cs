using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Items : Character
    {
        Player player;
        Renderer renderer;
        public bool taken;

        public Items(Player player, Renderer renderer) : base(renderer)
        {
            taken = false;
            this.player = player;
        }



        public virtual void Update()
        {

        }

        public virtual void Draw()
        {

        }

        public virtual void IsTaken() // if player takes it
        {
            
        }

    }
}
