using System;
using UnityEngine;

namespace Solid.ObjectBehaviour
{
    public interface IObjectBehaviour
    {
        void Feedback(GameObject source, Action onComplete);
    }
}