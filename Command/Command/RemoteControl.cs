using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public class RemoteControl
    {
        private Dictionary<string, ICommand> _commands;

        public RemoteControl()
        {
            _commands = new Dictionary<string, ICommand>();
        }

        public void SetCommand(string button, ICommand command)
        {
            _commands[button] = command;
        }

        public void PressButton(string button)
        {
            if( _commands.ContainsKey(button))
            {
                _commands[button].Execute();
            }
            else
            {
                Console.WriteLine("There is no command for this button");
            }
        }
    }
}
