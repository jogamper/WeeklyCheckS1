using UnityEngine;

namespace Check_6
{
    public class Healer : MonoBehaviour, IBuffable
    {
        public void Buff(GameObject buff)
        {
            Debug.Log("Healer Buff");
            Destroy(buff);
        }
    }
}