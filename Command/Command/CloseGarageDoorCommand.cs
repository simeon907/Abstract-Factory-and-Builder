using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class CloseGarageDoorCommand : ICommand
    {
        private GarageDoor _garageDoor;

        public CloseGarageDoorCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Close();
        }
    }
}
