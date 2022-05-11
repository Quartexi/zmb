using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    class Zombie : IZombie {

        public string name;
        public Zombie(string name) {
            this.name = name;
        }

        public void EnterMap(Map map, Observer observer) {
            map.RegisterZombie(this, map);
            observer.Update(map);
        }
    }
}
