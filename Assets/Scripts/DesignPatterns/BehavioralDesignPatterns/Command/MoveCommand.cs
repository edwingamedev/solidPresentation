namespace BehavioralDesignPatterns.Command
{
    public class MoveCommand : ICommand
    {
        private readonly Character character;
        private readonly IDirection direction;

        public MoveCommand(Character character, IDirection direction)
        {
            this.character = character;
            this.direction = direction;
        }

        public void Execute()
        {
            character.Move(direction.Current);
        }

        public void Undo()
        {
            character.Move(direction.Opposite);
        }
    }
}