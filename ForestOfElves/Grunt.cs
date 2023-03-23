using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Grunt : Enemy
    {
        Player player;
        Random random;
        Map map;
        public Grunt(Player player, Map map, Random random) : base(player,map,random) 
        {
            this.random = random;
            this.player = player;
            this.map = map;
            sprite = "G";
            howManyPlyrMoves = 2;
            amountLeft = howManyPlyrMoves;
            currentAttackChance = 6;
            
            
            //this.random = random;
        }
        public override void Start()
        {
            x = 12;
            y = 12;
            attacked = false;
            dead = false;
        }
        public override void Update()
        {
            
            previousX = x;
            previousY = y;
            attacked = false;
            //IsPlayerNear();
            amountLeft -= 1;
            if (dead)
            {
                return;
            }
            else
            {
                if (amountLeft == 0)
                {
                    Move();

                    amountLeft = howManyPlyrMoves;
                }
                if (x == player.x && y == player.y)
                {
                    Attacking();
                }
                if (attacked)
                {
                    TakeDamage();
                }
            }
            
        }
        public override void Draw()
        {
            whereIs(x, y, sprite);
        }
        public override void Move()
        {

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
        public override void IsPlayerNear()
        {
            int nearUp = y - 1;
            int nearDown = y + 1;
            int nearLeft = x - 1;
            int nearRight = x + 1;

            if (nearLeft == player.x && y == player.y || nearRight == player.x && y == player.y || x == player.x && nearUp == player.y || nearDown == player.y && x == player.x)
            {
            }
        }
        public override void TakeDamage()
        {
            health -= player.currentplayerDamage;

            if (health <= 0)
            {
                sprite = "k";
                dead = true;
                
            }
            return;
        }
        public override void Attacking()
        {

            currentEnemyDamage = 10;

            player.TakeDamage(currentEnemyDamage);
            x = previousX;
            y = previousY;

        }
    }
}
