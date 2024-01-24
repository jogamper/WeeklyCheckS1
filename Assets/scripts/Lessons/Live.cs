using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class Live : MonoBehaviour
    {
        private List<string> items;

// Start is called before the first frame update
        private void Start()
        {
            for (var i = 0; i < 10; i++) Debug.Log("Number" + i);
        }

        // Update is called once per frame
        private void Update()
        {
        }

        public void CheckDay(string day)
        {
            if (day == "Monday")
                Debug.Log("Oh noooo!");
            else if (day == "Tuesday")
                Debug.Log("ohhh babeyyyy");
        }
    }
}