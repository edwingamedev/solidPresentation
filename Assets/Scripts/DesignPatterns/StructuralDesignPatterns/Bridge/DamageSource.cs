namespace StructuralDesignPatterns.Bridge
{
    ///<summary>
    /// The Abstraction defines the interface for the "control" part of the two
    /// class hierarchies. It maintains a reference to an object of the
    /// Implementation hierarchy and delegates all of the real work to this
    /// object.
    /// </summary>
    public abstract class DamageSource
    {
        protected IWeapon weapon { set; get; }
        public abstract string Operation();
    }
}