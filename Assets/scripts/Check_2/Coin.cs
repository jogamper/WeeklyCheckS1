using UnityEngine;

namespace Check_2
{
    public class Coin : MonoBehaviour
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
            // check if colling game object is the player
            if (collision.gameObject.CompareTag("Player"))
                Destroy(gameObject);
        }
    }
}