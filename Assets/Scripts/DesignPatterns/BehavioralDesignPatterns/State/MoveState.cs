using UnityEngine;

namespace DesignPatterns.BehavioralDesignPatterns.State
{
    public class MoveState : AState
    {
        protected override string StateName => "State1";

        private Transform targetTransform;
        private Vector3 startPosition;
        
        public override void OnEnter()
        {
            base.OnEnter();
            Debug.Log($"{StateName} is the #1");
            stateUIController.SetColor(Color.yellow);

            targetTransform = stateUIController.cube.transform;
            startPosition = targetTransform.localPosition;
        }
        
        public override void Tick()
        {
            targetTransform.position = startPosition + 
                                       new Vector3(Mathf.Sin(Time.time), 
                                                   0.0f, 
                                                   -Mathf.Sin(Time.time));
        }

        public MoveState(StateUIController stateUIController) : base(stateUIController) { }
    }
}