using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    interface IZombie {

        void EnterMap(Map map, Observer observer);
    }
}
