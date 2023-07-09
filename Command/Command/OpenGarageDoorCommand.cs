using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class OpenGarageDoorCommand : ICommand
    {
        private GarageDoor garageDoor;

        public OpenGarageDoorCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Open();
        }
    }
}
