using System.Collections;
using UnityEngine;

namespace NonSolid.Units
{
    public class Player : MonoBehaviour
    {
        [SerializeField] private Renderer renderer;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                StartCoroutine(Shoot());
            }

            Vector3 direction = new Vector3(Input.GetAxis("Vertical"), 0, -Input.GetAxis("Horizontal"));
            Move(direction / 100);
        }

        private IEnumerator Shoot()
        {
            Material material = renderer.material;
            Color color = material.color;

            material.color = Color.white;

            yield return new WaitForSeconds(.1f);

            material.color = color;
        }

        private void Move(Vector3 direction)
        {
            transform.Translate(direction);
        }
    }
}