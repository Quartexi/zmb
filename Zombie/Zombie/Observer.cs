using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    class Observer : IObserver {

        List<Tuple<Jäger, Map>> jägerList = new List<Tuple<Jäger, Map>>();

        public void Update(Map map) {
            foreach (Tuple<Jäger, Map> jägerMap in jägerList) {
                if (jägerMap.Item2 == map) {
                    jägerMap.Item1.Notify();
                    Console.WriteLine($"Jäger {jägerMap.Item1.name} wurde zur Karte {map.name} informiert");
                }
            }
        }

        public void AddList(Jäger jäger, Map map) {
            jägerList.Add(new Tuple<Jäger, Map>(jäger, map));
        }
    }
}
