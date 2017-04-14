using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez
{
    class Player : IAction, IHaveGold, IDealDamage
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
        public const float BASE_GOLD_NEED = 25;
        // Variables
        Hero[] hero;
        public int iDamagePerClick
        {
            get
            {
                return hero[0].iCurrentDamagePerClick;
            }
        }
        public int iDamagePerSecond
        {
            get
            {
                int iSumDamage = 0;
                for (int i=1; i<hero.Length;i++)
                {
                    iSumDamage += hero[i].iCurrentDamagePerSecond;
                }
                return iSumDamage;
            }
        }
        private string sName;
        private float fGold;
        // Constructor
        public Player()
        {
            sName = "Default Player";
            fGold = 0;
            hero = new Hero[HERO_MAX_COUNT];
            for (int i=0;i<HERO_MAX_COUNT;i++)
            {
                hero[i] = new Hero(i);
            }
        }

        // Interfaces
        public void DoAction(int iAction,int iParameter)
        {
            switch (iAction)
            {
                case ACTION_DEAL_DAMAGE:
                    break;
                case ACTION_HERO_BUY:
                    if (fGold >= hero[iParameter].fGoldNeedToBuy)
                    {
                        fGold -= hero[iParameter].fGoldNeedToBuy;
                        hero[iParameter].Upgrade();
                    }
                    break;
                case ACTION_HERO_UPGRADE:
                    if (fGold>=hero[iParameter].fGoldNeedToUpgrade)
                    {
                        fGold -= hero[iParameter].fGoldNeedToUpgrade;
                        hero[iParameter].Upgrade();
                    }
                    break;
                case ACTION_LEVELUP:
                    break;
            }
        }

        public void TakeGold(float fAmount)
        {
            fGold += fAmount;
        }

        public void DealDamage(int amount, IDamageable target)
        {
            target.TakeDamage(amount);
        }
    }
}
