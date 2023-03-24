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
        Player player;
        Random random;
        
        public string sprite;
        public int x { get; set; }      
        public int y { get; set; }

        public int dx;
        public int dy;

        public int targetPosX;
        public int targetPosY;

        public int health;
        public int decay;

        public bool attacked;
        
        public int currentEnemyDamage; // how many player moves until it can do an action

        public int howManyPlyrMoves;
        public int amountLeft;

        public bool dead;

        public bool bossIsDead;

        public Enemy(Map map, Random random,Player player) // constructor
        {
            this.map = map;
        }
        public virtual void OnStart()
        {

        }
        public virtual void Update()
        {
            
        }
        public virtual void Draw()
        {
        }
        public virtual void GoingTo() //Where does it want to move
        {
        }
        public virtual void Move() // Moving to where it wants to move
        {
        }

        public virtual void TakeDamage()
        {           

        } 
        public virtual void Attacking()
        {
        }
        
        public virtual void IsPlayerNear()
        {
        }
    }
}
