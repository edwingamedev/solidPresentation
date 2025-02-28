namespace StructuralDesignPatterns.Bridge
{
    /// <summary>
    /// Each Concrete Implementation corresponds to a specific platform and
    /// implements the Implementation interface using that platform's API.
    /// </summary>
    public class Sword : IWeapon
    {
        public string Damage()
        {
            return "stab with a sword.";
        }
    }
    
    public class Lance : IWeapon
    {
        public string Damage()
        {
            return "stab with a lance.";
        }
    }
}