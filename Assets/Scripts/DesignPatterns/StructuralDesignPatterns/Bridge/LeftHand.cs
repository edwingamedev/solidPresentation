namespace StructuralDesignPatterns.Bridge
{
    /// <summary>
    /// You can extend the Abstraction without changing the Implementation
    /// classes.
    /// </summary>
    public class LeftHand : DamageSource
    {
        public LeftHand(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public override string Operation()
        {
            return  $"used left hand to {weapon.Damage()}";
        }
    }
}