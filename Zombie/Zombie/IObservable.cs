using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    public interface IObservable {
        public void Subscribe(IObserver observer);
        public void Unsubscribe(IObserver observer);
        public void Notify();
    }
}
