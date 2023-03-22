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

        public int KeyX;
        public int KeyY;

        public string HSprite = "H";
        public string SHSprite = "S";
        public string KeySprite = "K";

        public bool healthTaken = false;
        public bool shieldTaken = false;
        public bool keytaken = false;

        public void Update()
        {
            KeyUpdate();
            HealthItemUpdate();
            ShieldItemUpdate();
        }

        public void KeyUpdate()
        {
            if (keytaken == false)
            {
                TakeKey();
            }
            else return;

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
            HPotionX = 15;
            HPotionY = 7;
            
            whereIs(HPotionX, HPotionY, "H");
        }
        public void ShieldParts()
        {
            SPartX = 8;
            SPartY = 9;
            whereIs(SPartX, SPartY, "S");
        }
        public void KeyPosition()
        {
            KeyX = 10;
            KeyY = 10;
            whereIs(KeyX, KeyY, KeySprite);
        }
        public void TakeKey()
        {
            KeyPosition();
            if (player.x == KeyX && player.y == KeyY)
            {
                player.hasKey = player.hasKey + 1;
                KeySprite = " ";
            }
        }

        public void TakePotion()
        {
            HealthPotion();
            if (player.x == HPotionX && player.y == HPotionY)
            {
                healthTaken = true;
                
            }
            if (healthTaken)
            {
                HSprite = " ";
                player.howManyPotions++;
                
            }
        }
        public void TakeShield()
        {
            ShieldParts();
            if (player.x == SPartX && player.y == SPartY)
            {
                shieldTaken = true;
            }
            if (shieldTaken)
            {
                SHSprite = " ";
                player.howManyShields++;
            }
        }
    }
}
