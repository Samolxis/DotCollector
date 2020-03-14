using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float collectableSpawnTime = 1.0f;
    public float enemySpawnTime = 2.0f;
    float rngY,rngX;
    public GameObject collectable;
    public GameObject enemy;
    readonly bool canSpawnCollectable = true;
    readonly bool canSpawnEnemy = true;
    void Start()
    {
        StartCoroutine(SpawnCollectables());
        StartCoroutine(SpawnEnemies());
    }

    // Update is called once per frame


    IEnumerator SpawnCollectables()
    {
        while (canSpawnCollectable) {
            CollecableCreation();
        yield return new WaitForSeconds(collectableSpawnTime);
    }
    }

    IEnumerator SpawnEnemies()
    {
        while (canSpawnEnemy)
        {
            EnemyCreation();
            yield return new WaitForSeconds(enemySpawnTime);
        }
    }

    void EnemyCreation() {
        rngX = UnityEngine.Random.Range(-22, 22);
        rngY = UnityEngine.Random.Range(-9, 9);
        Instantiate(enemy, new Vector3(rngX, rngY, 0), Quaternion.identity);
    }

    void CollecableCreation ()
    {
        rngX = UnityEngine.Random.Range(-22,22);
        rngY = UnityEngine.Random.Range(-9,9);
        Instantiate(collectable,new Vector3(rngX,rngY,0) , Quaternion.identity);
    }
}
