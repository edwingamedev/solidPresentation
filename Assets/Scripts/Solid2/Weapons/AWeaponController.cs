using UnityEngine;

namespace Solid2.Weapons
{
    public abstract class AWeaponController : MonoBehaviour, IWeapon
    {
        public abstract void Shoot(Object source);
    }
}