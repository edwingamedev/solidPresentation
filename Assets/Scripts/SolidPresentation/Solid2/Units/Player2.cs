using System;
using Solid2.InputProvider;
using Solid2.Movement;
using Solid2.Weapons;
using UnityEngine;

namespace Solid2.Units
{
    public class Player2 : MonoBehaviour
    {
        [SerializeField] private AMovementController movementController;
        [SerializeField] private AWeaponController weaponController;

        private void Update()
        {
            movementController.Move(transform);
            weaponController.Shoot(gameObject);
        }
    }
}