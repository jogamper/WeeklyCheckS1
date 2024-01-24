using Check_5;
using Lessons;
using UnityEngine;

namespace Check_2
{
    public class Obstacle : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
        }
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                GameManager.instance.RestartGame();
            }
        }
    }
}