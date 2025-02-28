namespace StructuralDesignPatterns.Adapter
{
    public class AdapterDesignPattern : DesignPattern
    {
        protected override string name { get; set; } = "Adapter";
        private Gun9mm gun9mm;
        
        public void Start()
        {
            ShowName();
            
            Gun9mm();
            FlameThrower();
        }
        
        private void Gun9mm()
        {
            IAmmo bullets9Mm = new Bullets9mm();
            
            gun9mm = new Gun9mm(bullets9Mm);
            gun9mm.Shoot();
        }
        
        private void FlameThrower()
        {
            IFire fireAmmo = new FireAmmo();
            IAmmo ammo = new FlameThrowerAdapter(fireAmmo);
            
            gun9mm = new Gun9mm(ammo);
            gun9mm.Shoot();
        }
    }
}