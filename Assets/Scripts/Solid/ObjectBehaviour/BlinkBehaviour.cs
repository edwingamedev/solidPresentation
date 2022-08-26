using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Solid.ObjectBehaviour
{
    public class BlinkBehaviour : IObjectBehaviour
    {
        private Color Color { get; }

        public BlinkBehaviour(Color color)
        {
            Color = color;
        }

        public async void Feedback(GameObject source, Action onComplete)
        {
            Renderer renderer = source.GetComponentInChildren<Renderer>();
            Material material = renderer.material;
            Color defaultColor = material.color;

            await BlinkColor(material, defaultColor);

            onComplete?.Invoke();
        }


        private async Task BlinkColor(Material material, Color defaultColor)
        {
            material.color = Color;

            await Task.Delay(100);

            material.color = defaultColor;
        }
    }
}