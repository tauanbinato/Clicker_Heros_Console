using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez
{
    class Hero
    {
        // Constants
        public const int ACTION_DEAL_DAMAGE = 1;
        public const int ACTION_HERO_BUY = 2;
        public const int ACTION_HERO_UPGRADE = 3;
        public const int ACTION_LEVELUP = 4;
        public const int BASIC_HERO_TYPE = 1;
        public const int BASIC_HERO_DAMAGE = 1;
        public const int HERO_MAX_COUNT = 10;
        public const int HERO_MAX_LEVEL = 10;
        public const int ACTION_DAMAGE_PER_CLICK = 1;
        public const int ACTION_DAMAGE_PER_SECOND = 2;
        public const double BASE_GOLD_NEED = 25;
        // Variables
        private string sName;
        private int iLevel;                     // can be set between 1 to 10
        private int iType;                      // can be set between 1 to 10
        private int iBaseDamagePerClick;
        private int iBaseDamagePerSecond;
        public int iCurrentDamagePerClick
        {
            get
            {
                return iLevel * iBaseDamagePerClick;
            }
        }
        public int iCurrentDamagePerSecond
        {
            get
            {
                return iLevel* iBaseDamagePerSecond;
            }
        }
        public int iDamage
        {
            get
            {
                return iCurrentDamagePerClick + iCurrentDamagePerSecond;
            }
        }
        public double dGoldNeedToUpgrade
        {
            get
            {
                return BASE_GOLD_NEED * iLevel * iType;
            }
        }
        public double dGoldNeedToBuy
        {
            get
            {
                return BASE_GOLD_NEED * iType;
            }
        }
        // Constructors
        public Hero(int iHeroType)
        {
            sName = "Type "+iHeroType.ToString()+" Hero";
            iType = iHeroType;
            iLevel = 0;
            if (iHeroType == BASIC_HERO_TYPE)
            {
                iBaseDamagePerClick = BASIC_HERO_DAMAGE;
                iBaseDamagePerSecond = 0;
            }
            else
            {
                iBaseDamagePerClick = 0;
                iBaseDamagePerSecond = iHeroType;
            }
        }
        
        // Public Functions
        public void Upgrade()
        {
            if (iLevel<HERO_MAX_LEVEL)
            {
                iLevel++;
            }
        }
        // Private Functions

        // Interfaces

    }
}
