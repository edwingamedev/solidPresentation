namespace BehavioralDesignPatterns.Command
{
    public interface ICommand
    {
        void Execute();
        void Undo();
    }
}