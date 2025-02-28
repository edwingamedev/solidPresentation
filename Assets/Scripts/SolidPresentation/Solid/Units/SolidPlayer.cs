using Solid.InputProvider;
using Solid.Movement;
using Solid.Weapons;
using UnityEngine;

namespace Solid.Units
{
    public class SolidPlayer : MonoBehaviour, IWeaponSwapper
    {
        private IMovementController MovementController { get; set; }
        private IWeaponsController WeaponController { get; set; }
        private IShootInput ShootInput { get; set; }
        private IMovementInput MoveInput { get; set; }

        private void Awake()
        {
            MovementController = new PlayerMovementController();
            WeaponController = new SimpleWeaponController();
            ShootInput = new PlayerShootInput();
            MoveInput = new PlayerMovementInput();
        }

        private void Update()
        {
            WeaponController.Shoot(gameObject, ShootInput);
            MovementController.Move(transform, MoveInput);
        }

        public void ChangeWeapon(IWeapon weapon)
        {
            WeaponController.ChangeWeapon(weapon);
        }
    }
}