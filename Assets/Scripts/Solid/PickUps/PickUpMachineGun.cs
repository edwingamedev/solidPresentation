using Solid.Weapons;

namespace Solid.PickUps
{
    public class PickUpMachineGun : AWeaponPickup
    {
        protected override IWeapon Weapon => new MachineGun();
    }
}