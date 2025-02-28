using System;
using Solid2.InputProvider;
using UnityEngine;

namespace Solid2.Movement
{
    public class PlayerMovementController : AMovementController
    {
        [SerializeField] private AInputProvider inputProvider;

        public override void Move(Transform movable)
        {
            transform.Translate(inputProvider.GetDirection() / 100);
        }
    }
}