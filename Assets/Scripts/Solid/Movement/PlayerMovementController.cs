using Solid.InputProvider;
using UnityEngine;

namespace Solid.Movement
{
    public class PlayerMovementController : IMovementController
    {
        public void Move(Transform movable, IMovementInput shootInput)
        {
            movable.Translate(shootInput.GetDirection() / 100);
        }
    }
}