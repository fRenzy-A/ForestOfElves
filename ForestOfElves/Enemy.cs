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
        Map map;
        //Player player = new Player(); // a new player! uh-oh!!
        Player player; // reference to the player
        static Random random = new Random();

        public string sprite;

        public int x;
        public int y;

        public int health = 100;

        public int previousX;
        public int previousY;

        public bool attacked;
        
        public int currentEnemyDamage;
        public int currentAttackChance;

        public int howManyPlyrMoves;
        public int amountLeft;

        public bool dead = false;

        public Enemy(Player player, Map map) // constructor
        {
            this.player = player;
            this.map = map;   
        }

        public virtual void Update()
        {

        }
        public void Draw()
        {
            whereIs(x, y, sprite);
        }
        public void Move()
        {
            previousX = x;
            previousY = y;
            int move = random.Next(1, 5);
            if (move == 1)
            {
                x--;
            }
            if (move == 2)
            {
                x++;
            }
            if (move == 3)
            {
                y--;
            }
            if (move == 4)
            {
                y++;
            }
            bool wallchecker = map.WallChecker(x, y);
            if (wallchecker)
            {
                x = previousX;
                y = previousY;
            }

        }

        public void Combat()
        {
            TakeDamage();
            Attacking();
        }
        public virtual void TakeDamage()
        {           
            /*health -= player.currentplayerDamage;        

            if (health <= 0)
            {
                sprite = "k";
                dead = true;
                return;
            }*/
        } 
        public virtual void Attacking()
        {
      
            /*currentEnemyDamage = 10;

            player.TakeDamage(currentEnemyDamage);
            x = previousX;
            y = previousY;
            */
        }
        
        public virtual void IsPlayerNear()
        {
        }
    }
}
