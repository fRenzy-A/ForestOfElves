using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Items : Character
    {
        Player player;

        public Items(Player player)
        {
            this.player = player;
        }

        public int HPotionX;
        public int HPotionY;

        public int SPartX;
        public int SPartY;

        public string HSprite = "H";
        public string SHSprite = "S";

        public bool healthTaken = false;
        public bool shieldTaken = false;
        
        public void Update()
        {
            HealthItemUpdate();
            ShieldItemUpdate();
        }
        public void HealthItemUpdate()
        {

            
            if (healthTaken == false)
            {
                TakePotion();
            }
            else return;

        }
        public void ShieldItemUpdate()
        {
            if (shieldTaken == false)
            {
                TakeShield();
            }
            else return;
        }
        public void HealthPotion()
        {
            HPotionX = 7;
            HPotionY = 7;
            
            Position(HPotionX, HPotionY, "H");
        }
        public void ShieldParts()
        {
            SPartX = 8;
            SPartY = 9;
            Position(SPartX, SPartY, "S");

        }

        public void TakePotion()
        {
            HealthPotion();
            if (player.playerX == HPotionX && player.playerY == HPotionY)
            {
                healthTaken = true;
                
            }
            if (healthTaken)
            {
                HSprite = " ";
                player.health = player.health + 100;
                
            }
        }
        public void TakeShield()
        {
            ShieldParts();
            if (player.playerX == SPartX && player.playerY == SPartY)
            {
                shieldTaken = true;

            }
            if (shieldTaken)
            {
                SHSprite = " ";
                player.shield = player.shield + 100;
            }
        }
    }
}
