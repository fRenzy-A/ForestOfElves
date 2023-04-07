using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Settings
    {
        //player stats and render info
        public const int playerHealth = 100;
        public const int playerShield = 50;
        public const int playerPositionX = 11;
        public const int playerPositionY = 5;
        public const int playerDamage = 50;
        public const string playerSprite = "X";
        
        //enemy stats and render info
        //grunt
        public const int gruntHealth = 100;
        public const int gruntDamage = 30;
        public const string gruntSprite = "&";

        //speed/fast grunt
        public const int fastGruntHealth = 50;
        public const int fastGruntDamage = 10;
        public const string fastGruntSprite = "¤";
        //tank
        public const int tankHealth = 250;
        public const int tankDamage = 60;
        public const string tankSprite = "▓";
        //BOSS
        public const int BOSSHealth = 500;
        public const int BOSSDamage = 100;
        public const string BOSSSprite = "§";

        public const string DEADSprite = "k";

        //item stats and render info
        public const int howMuchWillPotionsGive = 50;
        public const int howMuchWillShieldsGive = 25;

        public const string healthSprite = "H";
        public const string shieldSprite = "S";
        public const string keypartSprite = "<";


    }
}
