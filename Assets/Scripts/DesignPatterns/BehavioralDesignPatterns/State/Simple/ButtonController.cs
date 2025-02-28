using UnityEngine;
using UnityEngine.UI;

namespace DesignPatterns.BehavioralDesignPatterns.State.Simple
{
    public class ButtonController : MonoBehaviour
    {
        private AButtonState currentState;
        public Button button;

        private void Start()
        {
            button.onClick.AddListener(ButtonPress);
        }

        public ButtonController()
        {
            ChangeState(new LockState(this));
        }
        
        public void ChangeState(AButtonState aButtonState)
        {
            currentState = aButtonState;
        }

        private void ButtonPress()
        {
            currentState.ButtonPress();
        }
    }
}