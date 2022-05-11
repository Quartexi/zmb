using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    class Map : IMap {
        public string name;
        public Map(string name) {
            this.name = name;
        }

        public void RegisterZombie(Zombie zombie, Map map) {
            Console.WriteLine($"{zombie.name} ist der Karte {map.name} beigetreten");
        }
    }
}
