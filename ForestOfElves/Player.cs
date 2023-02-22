using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Player : Character
    {       
        public void PlayerDraw(int moveX, int moveY)
        {
            Position(moveX, moveY, "X");
        }
    }
}
