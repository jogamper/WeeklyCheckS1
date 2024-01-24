using UnityEngine;

namespace Check_1
{
    public class UI : MonoBehaviour
    {
        public string welcomeMessage = "Welcome to our Weekly Check!";

        // Start is called before the first frame update
        private void Start()
        {
            Debug.Log(welcomeMessage);
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}