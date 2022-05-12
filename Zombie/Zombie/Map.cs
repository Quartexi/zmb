using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    class Map : IMap {
        public List<IObserver> observerList = new List<IObserver>();
        public List<IZombie> zombieList = new List<IZombie>();
        string name;

        public Map(string name) {
            this.name = name;
        }

        public void enterMap(IZombie zombie) {
            zombieList.Add(zombie);
            Notify();
        }

        public void Notify() {
            foreach (IObserver o in observerList) {
                o.Update();
            }
        }

        public void Subscribe(IObserver observer) {
            observerList.Add(observer);
        }

        public void Unsubscribe(IObserver observer) {
            observerList.Remove(observer);
        }
    }
}
