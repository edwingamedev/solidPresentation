using UnityEngine;

namespace StructuralDesignPatterns.Adapter
{
    // public class Gun9mm
    // {
    //     private Bullets9mm bullets;
    //
    //     public Gun9mm(Bullets9mm bullets)
    //     {
    //         this.bullets = bullets;
    //     }
    //     
    //     public void Shoot()
    //     {
    //         Debug.Log($"9mm Gun Shooting: {bullets.Shoot()}");
    //     }
    // }
    //
    
    public class Gun9mm
    {
        private IAmmo bullets;
    
        public Gun9mm(IAmmo bullets)
        {
            this.bullets = bullets;
        }
        
        public void Shoot()
        {
            Debug.Log($"9mm Gun Shooting: {bullets.Shoot()}");
        }
    }
}