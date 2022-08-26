using Solid.ObjectBehaviour;
using UnityEngine;

namespace Solid.Weapons
{
    public abstract class AWeapon : IWeapon
    {
        protected abstract float FireRate { get; set; }
        protected abstract IObjectBehaviour ObjectBehaviour { get; set; }

        private float NextShoot { get; set; }
        private bool isWeaponLocked;

        public virtual void Shoot(GameObject source)
        {
            if (!IsReady()) return;
            
            isWeaponLocked = true;
            ObjectBehaviour.Feedback(source, ResetCooldown);
        }

        private bool IsReady()
        {
            return !isWeaponLocked && Time.time > NextShoot;
        }

        private void ResetCooldown()
        {
            NextShoot = Time.time + FireRate;
            isWeaponLocked = false;
        }
    }
}