using System;
using Solid.InputProvider;
using UnityEditor.Build.Content;
using UnityEngine;

namespace Solid.Weapons
{
    public class SimpleWeaponController : IWeaponsController
    {
        private IWeapon currentWeapon = new NoWeapon();

        public void ChangeWeapon(IWeapon weapon)
        {
            currentWeapon = weapon;
        }

        public void Shoot(GameObject source, IShootInput shootInput)
        {
            if (shootInput.IsShooting())
                currentWeapon.Shoot(source);
        }
    }
}