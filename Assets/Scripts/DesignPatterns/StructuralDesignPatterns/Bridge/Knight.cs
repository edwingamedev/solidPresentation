using UnityEngine;

namespace StructuralDesignPatterns.Bridge
{
    public class Knight
    {
        // Except for the initialization phase, where an Abstraction object gets
        // linked with a specific Implementation object, the client code should
        // only depend on the Abstraction class. This way the client code can
        // support any abstraction-implementation combination.
        public void Attack(DamageSource damageSource)
        {
            Debug.Log($"Knight {damageSource.Operation()}");
        }
    }
}