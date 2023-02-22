using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Enemy : Character
    {
        
        

        public bool enemyMove;
        public void EnemyDraw(int enemyX,int enemyY)
        {
            enemyMove = false;
            GameManager location = new GameManager();
            
            Position(enemyX, enemyY, "Y");
            

            
        }
    }
}
