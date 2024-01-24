using UnityEngine;

namespace Check_6
{
    public class Guard : MonoBehaviour, IBuffable
    {
        public void Buff(GameObject buff)
        {
            Debug.Log("Guard Buff");
            Destroy(buff);
        }
    }
}