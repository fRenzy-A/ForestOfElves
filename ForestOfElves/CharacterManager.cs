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

        //public int x;
        //public int y;

        public int health;

        public CharacterManager()
        {
            health = 1;
        }
        public void Manager()
        {
            //Position(currentX, currentY);
            Player player = new Player();
            Enemy enemy = new Enemy();
            enemy.EnemyUpdate();
            player.PlayerUpdate();
        }
        static void Position(int x, int y)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write("X");
        }
    }
}
