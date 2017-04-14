using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez
{
    class Hero : IDealDamage
    {
        // Constants
        public const int ACTION_DEAL_DAMAGE = 1;
        public const int ACTION_UPGRADE_HERO = 2;
        public const int ACTION_LEVELUP = 3;
        public const int BASIC_HERO_TYPE = 1;
        public const int BASIC_HERO_DAMAGE = 1;
        public const int HERO_MAX_COUNT = 10;
        public const int HERO_MAX_LEVEL = 10;
        // Variables
        private string sName;
        private int iLevel;                     // can be set between 1 to 10
        private int iType;                      // can be set between 1 to 10
        private int iBaseDamagePerClick;
        private int iBaseDamagePerSecond;
        private int iCurrentDamagePerClick;
        private int iCurrentDamagePerSecond;

        // Constructors
        public Hero(int iHeroType)
        {
            sName = "Type "+iHeroType.ToString()+" Hero";
            iType = iHeroType;
            iLevel = 1;
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
            iCurrentDamagePerClick = iLevel * iBaseDamagePerClick;
            iCurrentDamagePerSecond = iLevel * iBaseDamagePerSecond;
        }
        
        // Public Functions
        void Upgrade()
        {
            if (iLevel<HERO_MAX_LEVEL)
            {
                iLevel++;
            }
        }
        // Private Functions
        
        // Interfaces
        public void DealDamage(int amount, IDamageable target)
        {
            target.TakeDamage(amount);
        }

    }
}
