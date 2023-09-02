using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TurnOffStereoCommand : ICommand
    {
        private Stereo _stereo;

        public TurnOffStereoCommand(Stereo stereo)
        {
            _stereo = stereo;
        }

        public void Execute()
        {
            _stereo.TurnOff() ;
        }
    }
}
