using UnityEngine;

namespace Solid.InputProvider
{
    public class PlayerShootInput : IShootInput
    {
        public bool IsShooting()
        {
            return Input.GetKey(KeyCode.Space);
        }
    }
}