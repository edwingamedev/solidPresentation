using UnityEngine;

namespace DesignPatterns.BehavioralDesignPatterns.State.Simple
{
    public abstract class AButtonState
    {
        protected readonly ButtonController Controller;
        public abstract void ButtonPress();

        protected AButtonState(ButtonController controller)
        {
            Controller = controller;
        }
    }
    
    public class LockState : AButtonState
    {
        public LockState(ButtonController controller) : base(controller) { }
        
        public override void ButtonPress()
        {
            Debug.Log("Locking...");

            Controller.ChangeState(new UnlockState(Controller));
        }
    }
    public class UnlockState : AButtonState
    {
        public UnlockState(ButtonController controller) : base(controller) { }
        public override void ButtonPress()
        {
            Debug.Log("Unlocking...");
            
            Controller.ChangeState(new LockState(Controller));
        }
    }
}