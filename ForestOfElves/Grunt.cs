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
        Map map;
        Player player;
        public bool isdead;
        public Grunt(Map map) : base(map) 
        {
            this.map = map;
            UserInput input = new UserInput();
            player = new Player(map,input);
            x = 12;
            y = 12;
            sprite = "G";
            howManyPlyrMoves = 2;
            amountLeft = howManyPlyrMoves;
            currentAttackChance = 6;
            isdead = false;
            
            
            //this.random = random;
        }
        public override void Start()
        {
            attacked = false;
        }
        public override void Update()
        {
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

                    if (map.WallChecker(targetPosX, targetPosY)) return;

                    if (player.IsPlayerAt(targetPosX, targetPosY))
                    {
                        Attacking();
                    }
                    x = targetPosX;
                    y = targetPosY;

                    amountLeft = howManyPlyrMoves;
                }
                
            }
            
        }
        public override void Draw()
        {
            whereIs(x, y, sprite);
        }
        public override void Move()
        {
            Random random = new Random();
            int move = random.Next(1, 4);
            if (move == 1)
            {
                dx = 0;
                dy = -1;
                //ndy = y - 1; 
            }
            if (move == 2)
            {
                dx = -1;
                dy = 0;
                //ndx = x - 1;
            }
            if (move == 3)
            {
                dx = 0;
                dy = 1;
                //dy = y + 1;
            }
            if (move == 4)
            {
                dx = 1;
                dy = 0;
                //dx = x + 1;
            }
            targetPosX = x + dx;
            targetPosY = y + dy;
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

        }
    }
}
