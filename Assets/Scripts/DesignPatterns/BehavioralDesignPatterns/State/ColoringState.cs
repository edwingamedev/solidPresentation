using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.BehavioralDesignPatterns.State
{
    public class ColoringState : AState
    {
        protected override string StateName => "State2";

        private List<Color> colors = new()
        {
            Color.green,
            Color.yellow,
            Color.red,
            Color.magenta,
            Color.blue,
            Color.cyan
        };

        private float timeStamp;
        private float coolDownPeriodInSeconds = .5f;

        private int colorIndex = 0;

        public override void OnEnter()
        {
            base.OnEnter();
            Debug.Log($"{StateName} is on fire");

            timeStamp = Time.time + coolDownPeriodInSeconds;
        }

        public override void Tick()
        {
            if (!(timeStamp <= Time.time)) 
                return;
            
            stateUIController.SetColor(colors[colorIndex % colors.Count]);
            timeStamp = Time.time + coolDownPeriodInSeconds;
            colorIndex++;
        }

        public ColoringState(StateUIController stateUIController) : base(stateUIController)
        {
        }
    }
}