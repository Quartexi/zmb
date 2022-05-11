using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    class Jäger : IJäger {

        public string name;
        public Jäger(string name) {
            this.name = name;
        }

        public void RegisterMap(Map map, Observer observer) {
            Console.WriteLine($"Jäger {this.name} ist der Karte {map.name} zugeordnet");
            observer.AddList(this, map);
        }

        public void Notify() {
            Console.WriteLine($"{this.name} ist informiert");
        }
    }
}
