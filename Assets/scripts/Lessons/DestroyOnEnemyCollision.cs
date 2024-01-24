using UnityEngine;

namespace Lessons
{
    public class DestroyOnEnemyCollision : MonoBehaviour
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
            if (collision.collider.CompareTag("Enemy")) Destroy(collision.gameObject);
        }
    }
}