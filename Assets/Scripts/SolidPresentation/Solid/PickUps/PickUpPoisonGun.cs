using Solid.Weapons;

namespace Solid.PickUps
{
    public class PickUpPoisonGun : AWeaponPickup
    {
        protected override IWeapon Weapon => new PoisonGun();
    }
}