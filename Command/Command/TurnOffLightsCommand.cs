using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TurnOffLightsCommand : ICommand
    {
        private RoomLights _roomLights;

        public TurnOffLightsCommand(RoomLights roomLights)
        {
            _roomLights = roomLights;
        }

        public void Execute()
        {
            _roomLights.TurnOff();
        }
    }
}
