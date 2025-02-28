namespace StructuralDesignPatterns.Adapter
{
    public class Bullets9mm : IAmmo
    {
        public string Shoot()
        {
            return "9mm bullets";
        }
    }
}