using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class RemoteControl
    {
        protected TVImplementation tv;

        public RemoteControl(TVImplementation tv)
        {
            this.tv = tv;
        }

        public abstract void PressPowerButton();
        public abstract void PressVolumeUpButton();
        public abstract void PressVolumeDownButton();
 
    }
}
