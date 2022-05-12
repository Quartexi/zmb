using System;

namespace Zombie {
    class Program {
        static void Main(string[] args) {
            IMap map = new Map("Lake");
            IJäger Kevin = new Jäger(map, "Kevin");
            IZombie zombie = new Zombie(map, "Robin");
        }
    }
}
