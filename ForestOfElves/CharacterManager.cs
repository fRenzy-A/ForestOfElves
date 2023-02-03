using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class CharacterManager
    {
        static Player player = new Player();
        static Enemy enemy = new Enemy();

        public int health = 1;

        public void Kill()
        {
            if (enemy.bufferX == player.bufferX && enemy.bufferY == player.bufferY)
            {
                health--;
            }
        }
    }
}
