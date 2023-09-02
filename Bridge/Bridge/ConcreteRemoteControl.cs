using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class ConcreteRemoteControl : RemoteControl
    {
        public ConcreteRemoteControl(TVImplementation tv) : base(tv)
        {
        }

        public override void PressPowerButton()
        {
            tv.TogglePower();
        }

        public override void PressVolumeUpButton()
        {
            tv.IncreaseVolume();
        }

        public override void PressVolumeDownButton()
        {
            tv.DecreaseVolume();
        }
    }
}
