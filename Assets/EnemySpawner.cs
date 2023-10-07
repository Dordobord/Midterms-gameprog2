using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject swarmerPrefab;
    [SerializeField] private GameObject bigSwarmPrefab;

    [SerializeField] private float swarmInterval = 3.5f;
    [SerializeField] private float bigSwarmInterval = 10f;
    void Start()
    {
        StartCoroutine(spawnEnemy(swarmInterval, swarmerPrefab));
        StartCoroutine(spawnEnemy(bigSwarmInterval, swarmerPrefab));
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);  
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5 ), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    }
}
