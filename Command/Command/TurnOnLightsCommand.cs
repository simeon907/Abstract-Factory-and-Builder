using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class TurnOnLightsCommand : ICommand
    {
        private RoomLights _roomLights;

        public TurnOnLightsCommand(RoomLights roomLights)
        {
            _roomLights = roomLights;
        }
        public void Execute()
        {
            _roomLights.TurnOn();
        }
    }
}
