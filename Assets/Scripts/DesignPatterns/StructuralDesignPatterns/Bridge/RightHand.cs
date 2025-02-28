namespace StructuralDesignPatterns.Bridge
{
    /// <summary>
    /// You can extend the Abstraction without changing the Implementation
    /// classes.
    /// </summary>
    public class RightHand : DamageSource
    {
        public RightHand(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public override string Operation()
        {
            return $"used right hand to {weapon.Damage()}";
        }
    }
}