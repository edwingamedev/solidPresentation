using Solid.ObjectBehaviour;
using UnityEngine;

namespace Solid.Weapons
{
    public class PoisonGun : AWeapon
    {
        protected sealed override float FireRate { get; set; }
        protected sealed override IObjectBehaviour ObjectBehaviour { get; set; }

        public PoisonGun()
        {
            FireRate = .75f;
            ObjectBehaviour = new BlinkBehaviour(Color.green);
        }
    }
}