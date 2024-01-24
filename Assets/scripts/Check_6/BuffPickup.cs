using Unity.VisualScripting;
using UnityEngine;

namespace Check_6
{
    public class BuffPickup : MonoBehaviour
    {
        private void OnCollisionEnter(Collision other)
        {
            // when the pick up collides with (other) object, it tries to get IBuffable interface from the other component
            IBuffable buffable = other.gameObject.GetComponent<IBuffable>();
            
            // ? checks that buffable is not null before calling the method
            buffable?.Buff(gameObject);

            // if we could use an if here we could destroys the pick up object
            // instead of sending it to the buffable to do that since it should only do so if its a player:
            // if(other.gameObject.CompareTag("Player"))
            //      Destroy(gameObject);
        }
    }
}