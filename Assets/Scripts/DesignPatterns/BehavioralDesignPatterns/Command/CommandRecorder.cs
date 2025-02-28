using System.Collections.Generic;
using UnityEngine;

namespace BehavioralDesignPatterns.Command
{
    public class CommandRecorder
    {
        private readonly Stack<ICommand> commands = new();

        public void Record(ICommand command)
        {
            commands.Push(command);
            command.Execute();
        }

        public void Rewind()
        {
            commands.TryPop(out ICommand command);

            if (command == null)
            {
                Debug.Log("Nothing to Undo");
                return;
            } 
            
            Debug.Log("Undo");
            command.Undo();
        }
    }
}