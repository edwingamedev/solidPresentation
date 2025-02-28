using UnityEngine;

namespace StructuralDesignPatterns.Bridge
{
    public class CodeWithoutBridge : DesignPattern
    {
        protected override string name { get; set; } = "No Bridge";
        private DamageSource damageSource;
        
        private void Start()
        {
            ShowName();
            
            KnightAttack();
        }
        
        private void KnightAttack()
        {
            Knight2 knight = new Knight2();

            knight.LeftAttackSword();
            knight.LeftAttackMace();
            
            knight.RightAttackSword();
            knight.RightAttackMace();
        }
    }

    public class Knight2
    {
        private LeftHand leftHand;
        private RightHand rightHand;

        public void LeftAttackSword()
        {
            leftHand = new LeftHand(new Sword());
            
            Debug.Log($"Knight {leftHand.Operation()}");
        }
        
        public void LeftAttackMace()
        {
            leftHand = new LeftHand(new Mace());
            
            Debug.Log($"Knight {leftHand.Operation()}");
        }
        
        public void RightAttackSword()
        {
            rightHand = new RightHand(new Sword());
            
            Debug.Log($"Knight {rightHand.Operation()}");
        }
        
        public void RightAttackMace()
        {
            rightHand = new RightHand(new Mace());
            
            Debug.Log($"Knight {rightHand.Operation()}");
        }
    }
}