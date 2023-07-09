using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWork
{
    public class Standby : State
    {
        public Standby(State state) 
        {
            Player = state.Player;
        }

        public Standby(MediaPlayer mediaPlayer)
        {
            Player = mediaPlayer;
        }
        public override void PlayButton()
        {
            Console.WriteLine("No event");
        }

        public override void SwitchButton()
        {
            Player.State = new Play(this);
            Console.WriteLine("Switched to play mode");
        }
    }
}
