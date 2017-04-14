using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez
{
    interface IGiveGold
    {
        void GiveGold(float fAmount, IHaveGold target);
    }
}
