using System.Collections.Generic;
using UnityEngine;

namespace Lessons
{
    public class Inventory : MonoBehaviour

    {
        private List<string> items;

        // Start is called before the first frame update
        private void Start()
        {
            items = new List<string> { "hammer", "sickle", "berry" };
            Debug.Log("Initial item list:");
            foreach (var item in items) Debug.Log(item);
            
            Debug.Log("Checking for hammer:");
            foreach (var item in items)
                if (item == "hammer")
                {
                    Debug.Log(item);
                    break;
                }
        }

        // Update is called once per frame
        private void Update()
        {
            // using lower index because list starts at 0
            if (Input.GetKeyDown(KeyCode.Alpha1))
                SelectItem(0);
            else if (Input.GetKeyDown(KeyCode.Alpha2))
                SelectItem(1);
            else if (Input.GetKeyDown(KeyCode.Alpha3)) SelectItem(2);
        }


        public void SelectItem(int index)
        {
            // check if index works with our list
            if (index >= 0 && index < items.Count)
                Debug.Log(items[index]);
            else
                Debug.Log("Incorrect index");
        }
    }
}