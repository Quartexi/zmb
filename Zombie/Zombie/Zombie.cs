using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    class Zombie : IZombie {
        string name;
        public Zombie(IMap map, string name) {
            this.name = name;
            map.enterMap(this);
        }
    }
}
