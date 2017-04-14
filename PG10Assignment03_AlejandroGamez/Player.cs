using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez
{
    class Player : IAction
    {
        // Constants
        public const int ACTION_DEAL_DAMAGE = 1;
        public const int ACTION_UPGRADE = 2;
        public const int ACTION_LEVELUP = 3;
        public const int BASIC_HERO_TYPE = 1;
        public const int BASIC_HERO_DAMAGE = 1;
        public const int HERO_MAX = 10;
        // Variables
        string sName;
        double dGold;
        Hero[] hero;
        // Constructor
        public Player()
        {
            sName = "Default Player";
            dGold = 0;
            hero = new Hero[HERO_MAX];
            hero[0] = new Hero(BASIC_HERO_TYPE);
        }

        // Interfaces
        public void DoAction(int iAction)
        {
            switch (iAction)
            {
                case ACTION_DEAL_DAMAGE:
                    //DealDamage(iCurrentDamagePerClick, )
                    break;
                case ACTION_UPGRADE:
                    break;
                case ACTION_LEVELUP:
                    break;
            }
        }
    }
}
