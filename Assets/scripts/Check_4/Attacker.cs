using UnityEngine;

namespace Check_4
{
    public class Attacker : MonoBehaviour
    {
        public GameObject projectileFab;

        public float launchForce = 1000f;

        // spawnPos is calculated in the Attack method

        // Start is called before the first frame update
        private void Start()
        {
        }

        // Update is called once per frame
        private void Update()
        {
            // left mouse click because Space is already used
            if (Input.GetKeyDown(KeyCode.Mouse0)) Attack();
        }

        private void Attack()
        {
            // calculate the spawn point for the projectile based on the attackers position
            var playerPos = transform.position;
            var playerDirection = transform.forward;
            var spawnDistance = transform.localScale.x * 0.7f;
            var spawnPos = playerPos + playerDirection * spawnDistance;

            // initiate and launch the projectile forward
            var projectile = Instantiate(projectileFab, spawnPos, transform.rotation).GetComponent<Projectile>();
            projectile.Launch(transform.forward, launchForce);
        }
    }
}