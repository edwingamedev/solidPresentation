using UnityEngine;

namespace DesignPatterns.BehavioralDesignPatterns.State
{
    public class GreenState : AState
    {
        protected override string StateName => "State3";
        
        public override void OnEnter()
        {
            base.OnEnter();
            Debug.Log($"{StateName} is the best");
            stateUIController.SetColor(Color.green);
        }

        public GreenState(StateUIController stateUIController) : base(stateUIController) { }
    }
}