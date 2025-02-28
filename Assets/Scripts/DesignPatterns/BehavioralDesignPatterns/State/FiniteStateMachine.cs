using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.BehavioralDesignPatterns.State
{
    public class FiniteStateMachine
    {
        private Dictionary<Type, List<Transition>> Transitions { get; } = new();
        private List<Transition> currentTransitions = new();
        private readonly List<Transition> emptyTransitions = new(0);
        private IState currentState;
        private Transition currentTransition;
        
        public void Run()
        {
            if (ShouldTransition()) 
                SetState(currentTransition.To);
            
            currentState?.Tick();
        }

        private bool ShouldTransition()
        {
            currentTransition = GetTransition();

            return currentTransition != null;
        }
        
        private Transition GetTransition()
        {
            return currentTransitions.FirstOrDefault(transition => transition.Condition());
        }

        public void AddTransition(IState from, IState to, Func<bool> condition)
        {
            if (Transitions.TryGetValue(from.GetType(), out List<Transition> stateTransitions) == false)
            {
                stateTransitions = new List<Transition>();
                Transitions[from.GetType()] = stateTransitions;
            }

            stateTransitions.Add(new Transition(to, condition));
        }
        
        public void SetState(IState state)
        {
            if (state == currentState)
                return;

            currentState?.OnExit();
            currentState = state;
            
            Transitions.TryGetValue(currentState.GetType(), out currentTransitions);
            currentTransitions ??= emptyTransitions;
            
            currentState?.OnEnter();
        }

        
    }
}