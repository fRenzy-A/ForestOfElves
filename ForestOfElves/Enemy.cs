using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Enemy
    {
        static Random random = new Random();

        public void EnemyManager()
        {

        }
        static void Position()
        {

        }
        static void EnemyUpdate()
        {
            int move = random.Next(1, 5);
        }
    }
}
