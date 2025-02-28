namespace StructuralDesignPatterns.Adapter
{
    /// <summary>
    ///  The Adapter makes the Adaptee's interface compatible with the Target's
    ///  interface.
    /// </summary>
    public class FlameThrowerAdapter : IAmmo
    {
        private readonly IFire fireAmmo;

        public FlameThrowerAdapter(IFire fireAmmo)
        {
            this.fireAmmo = fireAmmo;
        }

        public string Shoot()
        {
            return fireAmmo.Flamethrower();
        }
    }
}