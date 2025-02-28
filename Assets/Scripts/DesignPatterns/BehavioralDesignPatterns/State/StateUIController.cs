using TMPro;
using UnityEngine;

namespace DesignPatterns.BehavioralDesignPatterns.State
{
    public class StateUIController : MonoBehaviour
    {
        public TMP_Text text;

        public GameObject cube;
        
        public void SetText(string text)
        {
            this.text.text = text;
        }

        public void SetColor(Color color)
        {
            cube.GetComponent<Renderer>().material.color = color;
        }
    }
}