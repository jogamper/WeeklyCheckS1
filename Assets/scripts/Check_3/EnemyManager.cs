using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Check_3
{
    public class EnemyManager : MonoBehaviour
    {
        // enemy prefab connected in unity editor to our premade GameObject
        public GameObject enemyFab;
        private List<GameObject> _enemies;

        // Start is called before the first frame update
        private void Start()
        {
            _enemies = new List<GameObject>();
            PrintAllNames();
        }

        // Update is called once per frame
        private void Update()
        {
            if (Input.GetKey(KeyCode.S))
                SpawnEnemy(new Vector3(Random.Range(-5f, 5), 0, Random.Range(-5f, 5)));
            if (Input.GetKey(KeyCode.P))
                PrintAllNames();
        }

        private void OnApplicationQuit()
        {
            foreach (var enemy in _enemies) Destroy(enemy);
        }

        private void SpawnEnemy(Vector3 position)
        {
            _enemies.Add(Instantiate(enemyFab, position, Quaternion.identity));
            _enemies[_enemies.Count - 1].name = "Enemy" + _enemies.Count;
            _enemies[_enemies.Count - 1].tag = "Hittable";
        }

        private void PrintAllNames()
        {
            foreach (GameObject enemy in _enemies) 
                Debug.Log(enemy.name);
        }
    }
}