using UnityEngine;

namespace BehavioralDesignPatterns.Command
{
    public class JumpCommand : ICommand
    {
        private readonly Character character;        

        public JumpCommand(Character character)
        {
            this.character = character;
        }
        
        public void Execute()
        {
            character.Jump();
        }
        
        public void Undo()
        {
            character.Fall();
        }
    }
}