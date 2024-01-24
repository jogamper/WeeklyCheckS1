using UnityEngine;

namespace Check_5
{
    public class Rotator : Obstacle
    {
        public float rotationSpeed = 1f;

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
            transform.Rotate(transform.up, rotationSpeed % 360);
        }
    }
}