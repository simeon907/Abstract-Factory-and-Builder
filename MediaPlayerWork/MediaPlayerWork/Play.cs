using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWork
{
    public class Play : State
    {
        public Play(State state)
        {
            Player = state.Player;
        }
        public override void PlayButton()
        {
            Console.WriteLine("Media paused");
            Player.State=new Pause(this);
        }

        public override void SwitchButton()
        {
            Console.WriteLine("Switched to radio mode");
            Player.State= new Radio(this);
        }
    }
}
