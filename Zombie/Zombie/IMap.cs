using System;
using System.Collections.Generic;
using System.Text;

namespace Zombie {
    public interface IMap : IObservable {
        public void enterMap(IZombie zombie);
    }
}
