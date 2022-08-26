using UnityEngine;

namespace Solid2.InputProvider
{
    public abstract class AInputProvider : MonoBehaviour, InputProvider
    {
        public abstract Vector3 GetDirection();
        public abstract bool IsShooting();
    }
}