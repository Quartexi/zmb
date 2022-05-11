using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    interface IJäger {
        void RegisterMap(Map map, Observer observer);
        void Notify();
    }
}
