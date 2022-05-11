using System;

namespace Zombie {
    class Program {
        static void Main(string[] args) {
            Observer observer = new Observer();

            Jäger Kevin = new Jäger("Kevin");
            Jäger Peter = new Jäger("Peter");
            Jäger Jürgen = new Jäger("Jürgen");

            Zombie zombie1 = new Zombie("hans");
            Zombie zombie2 = new Zombie("robin");
            Zombie zombie3 = new Zombie("stegemann");

            Map map1 = new Map("city");
            Map map2 = new Map("lake");

            Kevin.RegisterMap(map1, observer);
            Peter.RegisterMap(map1, observer);
            Jürgen.RegisterMap(map2, observer);

            zombie1.EnterMap(map1, observer);
            zombie2.EnterMap(map2, observer);
            zombie3.EnterMap(map1, observer);
        }
    }
}
