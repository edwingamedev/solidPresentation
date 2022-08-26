using UnityEngine;

namespace Solid2.Movement
{
    public abstract class AMovementController : MonoBehaviour, IMovement
    {
        public abstract void Move(Transform movable);
    }
}