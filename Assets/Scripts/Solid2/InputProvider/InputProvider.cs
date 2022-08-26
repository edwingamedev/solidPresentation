using UnityEngine;

namespace Solid2.InputProvider
{
    public interface InputProvider
    {
        Vector3 GetDirection();
        bool IsShooting();
    }
}