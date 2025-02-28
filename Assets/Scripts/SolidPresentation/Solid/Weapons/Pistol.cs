using Solid.ObjectBehaviour;
using UnityEngine;

namespace Solid.Weapons
{
    public class Pistol : AWeapon
    {
        protected sealed override float FireRate { get; set; }
        protected sealed override IObjectBehaviour ObjectBehaviour { get; set; }

        public Pistol()
        {
            FireRate = .5f;
            ObjectBehaviour = new BlinkBehaviour(Color.white);
        }
    }
}