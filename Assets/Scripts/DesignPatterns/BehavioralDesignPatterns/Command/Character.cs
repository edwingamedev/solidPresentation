using UnityEngine;

namespace BehavioralDesignPatterns.Command
{
    public class Character : MonoBehaviour
    {
        public Transform transform;
        
        public void Jump()
        {
            transform.Translate(Vector3.up);
            Debug.Log(" Jumped");
        }
        
        public void Fall()
        {
            transform.Translate(Vector3.down);
            Debug.Log(" Fell");
        }

        public void Move(DirectionType direction)
        {
            switch (direction)
            {
                case DirectionType.Left:
                    MoveLeft();
                    break;
                case DirectionType.Right:
                    MoveRight();
                    break;
            }
        }
        
        private void MoveLeft()
        {
            transform.Translate(Vector3.left);
            Debug.Log(" Moved Left");
        }
        
        private void MoveRight()
        {
            transform.Translate(Vector3.right);
            Debug.Log(" Moved Right");
        }
    }
}