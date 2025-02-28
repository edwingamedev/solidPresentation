using Solid.ObjectBehaviour;
using UnityEngine;

namespace Solid.Weapons
{
    public class MachineGun : AWeapon
    {
        protected sealed override float FireRate { get; set; }
        protected sealed override IObjectBehaviour ObjectBehaviour { get; set; }

        public MachineGun()
        {
            FireRate = .25f;
            ObjectBehaviour = new BlinkBehaviour(Color.red);
        }
    }
}