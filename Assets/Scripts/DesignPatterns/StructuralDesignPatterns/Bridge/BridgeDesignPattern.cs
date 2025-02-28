namespace StructuralDesignPatterns.Bridge
{
    public class BridgeDesignPattern : DesignPattern
    {
        protected override string name { get; set; } = "Bridge";
        private DamageSource damageSource;
        private void Start()
        {
            ShowName();
            
            KnightAttack();
            FighterAttack();
        }
        
        private void KnightAttack()
        {
            Knight knight = new Knight();

            damageSource = new RightHand(new Lance());
            knight.Attack(damageSource);

            damageSource = new LeftHand(new Mace());
            knight.Attack(damageSource);
        }
        
        private void FighterAttack()
        {
            Fighter fighter = new Fighter();

            damageSource = new RightHand(new Mace());
            fighter.Attack(damageSource);

            damageSource = new LeftHand(new Sword());
            fighter.Attack(damageSource);
        }
    }
}