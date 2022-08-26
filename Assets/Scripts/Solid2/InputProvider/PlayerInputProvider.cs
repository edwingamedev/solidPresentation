using UnityEngine;

namespace Solid2.InputProvider
{
    public class PlayerInputProvider : AInputProvider
    {
        public override Vector3 GetDirection()
        {
            return new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
        }

        public override bool IsShooting()
        {
            return Input.GetKey(KeyCode.Space);
        }
    }
}