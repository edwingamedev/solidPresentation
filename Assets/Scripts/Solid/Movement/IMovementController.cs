using Solid.InputProvider;
using UnityEngine;

namespace Solid.Movement
{
    public interface IMovementController
    {
        void Move(Transform movable, IMovementInput shootInput);
    }
}