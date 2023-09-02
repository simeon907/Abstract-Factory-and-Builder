using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GarageDoor garageDoor = new GarageDoor();
            Stereo stereo = new Stereo();
            RoomLights roomLights = new RoomLights();   

            OpenGarageDoorCommand openGarageDoorCommand = new OpenGarageDoorCommand(garageDoor);
            CloseGarageDoorCommand closeGarageDoorCommand = new CloseGarageDoorCommand(garageDoor);
            TurnOnStereoCommand turnOnStereoCommand = new TurnOnStereoCommand(stereo);
            TurnOffStereoCommand turnOffStereoCommand = new TurnOffStereoCommand(stereo);
            TurnOnLightsCommand turnOnLightsCommand = new TurnOnLightsCommand(roomLights);
            TurnOffLightsCommand turnOffLightsCommand = new TurnOffLightsCommand(roomLights);

            RemoteControl remoteControl = new RemoteControl();

            remoteControl.SetCommand("A", openGarageDoorCommand);
            remoteControl.SetCommand("B", closeGarageDoorCommand);
            remoteControl.SetCommand("C", turnOnStereoCommand);
            remoteControl.SetCommand("D", turnOffStereoCommand);
            remoteControl.SetCommand("E", turnOnLightsCommand);
            remoteControl.SetCommand("F", turnOffLightsCommand);

            remoteControl.PressButton("A");
            remoteControl.PressButton("B");
            remoteControl.PressButton("C");
            remoteControl.PressButton("D");
            remoteControl.PressButton("E");
            remoteControl.PressButton("F");

            Console.ReadKey();
        }
    }
}
