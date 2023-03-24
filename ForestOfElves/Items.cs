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
        public bool taken;

        public Items(Player player)
        {
            taken = false;
            this.player = player;
        }

        public int x { get; set; }
        public int y { get; set; }


        public string sprite;

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
