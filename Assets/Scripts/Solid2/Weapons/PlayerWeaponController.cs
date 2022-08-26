using System.Collections;
using Solid2.InputProvider;
using UnityEngine;

namespace Solid2.Weapons
{
    public class PlayerWeaponController : AWeaponController
    {
        [SerializeField] private Renderer renderer;
        [SerializeField] private AInputProvider inputProvider;
        private bool cooldown = false;
        
        public override void Shoot(Object source)
        {
            if (cooldown || !inputProvider.IsShooting()) return;
            
            cooldown = true;
            StartCoroutine(Shoot());
        }
    
        private IEnumerator Shoot()
        {
            Material material = renderer.material;
            Color color = material.color;

            material.color = Color.white;

            yield return new WaitForSeconds(.1f);

            material.color = color;
            
            cooldown = false;
        }
    }
}