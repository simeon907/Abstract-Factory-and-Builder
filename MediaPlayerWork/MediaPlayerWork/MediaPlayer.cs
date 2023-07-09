using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWork
{
    public class MediaPlayer
    {
        public State State {  get; set; }

        public MediaPlayer()
        {
            State = new Standby(this);
        }

        public void PlayButton()
        {
            State.PlayButton();
        }

        public void SwitchButton()
        {
            State.SwitchButton();
        }
    }
}
