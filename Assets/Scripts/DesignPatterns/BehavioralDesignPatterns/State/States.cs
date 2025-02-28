using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.BehavioralDesignPatterns.State
{
    public interface IState
    {
        void OnEnter();
        void OnExit();
        void Tick();
    }
    
    public abstract class AState : IState
    {
        protected abstract string StateName { get; }

        protected StateUIController stateUIController;

        protected AState(StateUIController stateUIController)
        {
            this.stateUIController = stateUIController;
        }
        
        public virtual void OnEnter()
        {
            Debug.Log($"Entering {StateName}");
            stateUIController.SetText($"Entering {StateName}");
        }

        public virtual void OnExit()
        {
            Debug.Log($"Exiting {StateName}");
            stateUIController.SetText($"Exiting {StateName}");
        }

        public virtual void Tick() { }
    }

    public class State4 : AState
    {
        public State4(StateUIController stateUIController) : base(stateUIController) { }

        protected override string StateName { get; }
        
        public override void OnEnter()
        {
            Debug.Log($"Entering {StateName}");
            stateUIController.SetColor(Color.black);
        }
    }
}