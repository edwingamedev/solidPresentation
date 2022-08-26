using UnityEngine;

namespace Solid.Movement
{
    public class PlayerMovementInput : IMovementInput
    {
        public Vector3 GetDirection()
        {
            return new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
        }
    }
}