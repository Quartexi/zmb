using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    class Jäger : IJäger {
        string name;
        public Jäger(IMap map, string name) {
            this.name = name;
            map.Subscribe(this);
        }
        public void Update() {
            Console.WriteLine($"Jäger {name} wurde benachrichtigt");
        }
    }
}
