using UnityEngine;

namespace Check_1
{
    public class Health : MonoBehaviour
    {
        public int playerHealth = 100;

        // Start is called before the first frame update
        private void Start()
        {
            Debug.Log(playerHealth);
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}