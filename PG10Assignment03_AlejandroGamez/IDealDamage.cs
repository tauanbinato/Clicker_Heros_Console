using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PG10Assignment03_AlejandroGamez {
    interface IDealDamage {
        void DealDamage(int amount, IDamageable target);
    }

}
