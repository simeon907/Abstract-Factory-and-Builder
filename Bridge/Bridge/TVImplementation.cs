using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class TVImplementation
    {
        public abstract void TogglePower();
        public abstract void IncreaseVolume();
        public abstract void DecreaseVolume();

    }
}
