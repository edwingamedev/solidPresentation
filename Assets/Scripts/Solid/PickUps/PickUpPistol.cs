using Solid.Weapons;

namespace Solid.PickUps
{
    public class PickUpPistol : AWeaponPickup
    {
        protected override IWeapon Weapon => new Pistol();
    }
}