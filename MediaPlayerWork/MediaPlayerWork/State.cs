using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWork
{
    public abstract class State
    {
        public MediaPlayer Player { get; set; }

        public abstract void PlayButton();
        public abstract void SwitchButton();
    }
}
