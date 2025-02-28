using Solid.InputProvider;
using UnityEngine;

namespace Solid.Weapons
{
    public interface IWeaponsController : IWeaponSwapper
    {
        void Shoot(GameObject source, IShootInput shootInput);
    }
}