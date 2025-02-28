namespace BehavioralDesignPatterns.Command
{
    public class LeftDirection : IDirection
    {
        public DirectionType Current { get; private set; } = DirectionType.Left;
        public DirectionType Opposite { get; private set; } = DirectionType.Right;
    }
    
    public class RightDirection : IDirection
    {
        public DirectionType Current { get; private set; } = DirectionType.Right;
        public DirectionType Opposite { get; private set; } = DirectionType.Left;
    }
    
    public interface IDirection
    {
        DirectionType Current { get; }
        DirectionType Opposite { get; }
    }

    public enum DirectionType
    {
        Left, Right
    } 
}