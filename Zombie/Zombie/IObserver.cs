using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    interface IObserver {
        void Update(Map map);
        void AddList(Jäger jäger, Map map);
    }
}
