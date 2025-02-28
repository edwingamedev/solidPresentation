using Solid.Weapons;
using UnityEngine;

namespace Solid.PickUps
{
    public abstract class AWeaponPickup : MonoBehaviour
    {
        protected abstract IWeapon Weapon { get; }

        private void ChangeWeapon(IWeaponSwapper weaponSwapper)
        {
            weaponSwapper.ChangeWeapon(Weapon);
        }
        
        private void OnTriggerEnter(Collider other)
        {
            if (GetWeaponSwapper(other, out var weaponSwapper)) return;

            ChangeWeapon(weaponSwapper);
        }

        private static bool GetWeaponSwapper(Component other, out IWeaponSwapper weaponSwapper)
        {
            return !other.transform.root.TryGetComponent(out weaponSwapper);
        }
    }
}