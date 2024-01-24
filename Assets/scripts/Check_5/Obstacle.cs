using Lessons;
using UnityEngine;

namespace Check_5
{
    public abstract class Obstacle : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
        }

        private void OnCollisionEnter(Collision collision)
        {
            GameManager.instance.RestartGame();
        }

        protected abstract void Move();
    }
}