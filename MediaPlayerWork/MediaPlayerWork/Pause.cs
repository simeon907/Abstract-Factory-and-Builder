using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWork
{
    public class Pause : State
    {
        public Pause(State state)
        {
            Player = state.Player;   
        }
        public override void PlayButton()
        {
            Console.WriteLine("Media is playing");
            Player.State = new Play(this);
        }

        public override void SwitchButton()
        {
            Console.WriteLine("Switched to radio mode");
            Player.State=new Radio(this);
        }
    }
}
