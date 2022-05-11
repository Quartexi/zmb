using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    interface IMap {
        void RegisterZombie(Zombie zombie, Map map);
    }
}
