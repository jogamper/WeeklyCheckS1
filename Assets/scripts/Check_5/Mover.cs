using UnityEngine;

namespace Check_5
{
    public class Mover : Obstacle
    {
        public int moveDistance = 10;
        public float moveSpeed = 2f;

        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            Move();
        }

        protected override void Move()
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,
                Mathf.PingPong(Time.time * moveSpeed, moveDistance) - moveDistance / moveSpeed);
        }
    }
}