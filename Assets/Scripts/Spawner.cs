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
    bool canSpawnCollectable = true;
    bool canSpawnEnemy = true;
    void Start()
    {
        StartCoroutine(spawnCollectables());
        StartCoroutine(spawnEnemies());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnCollectables()
    {
        while (canSpawnCollectable) {
            collecableCreation();
        yield return new WaitForSeconds(collectableSpawnTime);
    }
    }

    IEnumerator spawnEnemies()
    {
        while (canSpawnEnemy)
        {
            enemyCreation();
            yield return new WaitForSeconds(enemySpawnTime);
        }
    }

    void enemyCreation() {
        rngX = UnityEngine.Random.Range(-22, 22);
        rngY = UnityEngine.Random.Range(-9, 9);
        Instantiate(enemy, new Vector3(rngX, rngY, 0), Quaternion.identity);
    }

    void collecableCreation ()
    {
        rngX = UnityEngine.Random.Range(-22,22);
        rngY = UnityEngine.Random.Range(-9,9);
        Instantiate(collectable,new Vector3(rngX,rngY,0) , Quaternion.identity);
    }
}
