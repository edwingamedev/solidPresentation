using UnityEngine;

namespace DesignPatterns.BehavioralDesignPatterns.State
{
    public class StateDesignPattern : DesignPattern
    {
        protected override string name { get; set; } = "State";
        private FiniteStateMachine stateMachine;
        private bool shouldTick;
        [SerializeField] private StateUIController uiController;

        private void Start()
        {
            AState state1 = new MoveState(uiController);
            AState state2 = new ColoringState(uiController);
            AState state3 = new GreenState(uiController);
            AState state4 = new State4(uiController);

            stateMachine = new FiniteStateMachine();

            // Add transitions for all the states
            stateMachine.AddTransition(state1, state2, Press1);
            stateMachine.AddTransition(state1, state3, Press2);
            stateMachine.AddTransition(state1, state4, Press3);

            stateMachine.AddTransition(state2, state1, Press2);
            stateMachine.AddTransition(state2, state3, Press1);

            stateMachine.AddTransition(state3, state2, Press2);
            stateMachine.AddTransition(state3, state1, Press1);

            stateMachine.AddTransition(state4, state2, Press3);
            // Set initial state
            stateMachine.SetState(state1);
        }

        private void Update()
        {
            stateMachine?.Run();
        }

        private bool Press1()
        {
            return Input.GetKeyDown(KeyCode.Alpha1);
        }

        private bool Press2()
        {
            return Input.GetKeyDown(KeyCode.Alpha2);
        }
        
        private bool Press3()
        {
            return Input.GetKeyDown(KeyCode.Space);
        }
    }
}