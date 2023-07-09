using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayerWork
{
    public class Radio : State
    {
        public Radio(State state)
        {
            Player = state.Player;
        }
        public override void PlayButton()
        {
            Console.WriteLine("Moved to next radio channel");
        }

        public override void SwitchButton()
        {
            Console.WriteLine("Switched to standby mode");
            Player.State = new Standby(this);
        }
    }
}
