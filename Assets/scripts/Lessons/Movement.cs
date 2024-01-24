using UnityEngine;

namespace Lessons
{
    public class Movement : MonoBehaviour
    {
        public float speed = 1.5f;

        public float jumpForce = 3f;

        private Rigidbody _rb;

        // Start is called before the first frame update
        private void Start()
        {
            _rb = GetComponent<Rigidbody>();
            Debug.Log(speed);
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKey(KeyCode.W))
                transform.Translate(Vector3.forward * (Time.deltaTime * speed));
            if (Input.GetKey(KeyCode.S))
                transform.Translate(Vector3.back * (Time.deltaTime * speed));
            if (Input.GetKey(KeyCode.A))
                transform.Translate(Vector3.left * (Time.deltaTime * speed));
            if (Input.GetKey(KeyCode.D))
                transform.Translate(Vector3.right * (Time.deltaTime * speed));
            if (Input.GetKeyDown(KeyCode.Space))
                _rb.velocity = new Vector3(_rb.velocity.x, jumpForce, _rb.velocity.z);
        }
    }
}