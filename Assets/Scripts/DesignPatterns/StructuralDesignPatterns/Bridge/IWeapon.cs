namespace StructuralDesignPatterns.Bridge
{
    /// <summary>
    /// The Implementation defines the interface for all implementation classes.
    /// It doesn't have to match the Abstraction's interface. In fact, the two
    /// interfaces can be entirely different. Typically the Implementation
    /// interface provides only primitive operations, while the Abstraction
    /// defines higher- level operations based on those primitives.
    /// </summary>
    public interface IWeapon
    {
        string Damage();
    }
}