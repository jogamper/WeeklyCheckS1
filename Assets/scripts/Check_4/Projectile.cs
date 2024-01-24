using UnityEngine;

namespace Check_4
{
    public class Projectile : MonoBehaviour
    {
        public enum Type
        {
            Fire = 0,
            Ice = 1,
            Plant = 2,
            Air = 3
        }

        public Type type = Type.Air;

        public int damage = 10;

        private Rigidbody _rb;

        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            if (transform.position.y <= 0) Destroy(gameObject);
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Hittable"))
            {
                Destroy(collision.gameObject);
            }
            Destroy(gameObject);
        }

        public void Launch(Vector3 direction, float launchForce)
        {
            _rb.AddForce(direction * launchForce);
        }
    }
}