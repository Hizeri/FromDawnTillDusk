using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] List<GameObject> aliveEnemies;
    private int lastChoosedSpawnPointIndex;


    [SerializeField] private GameObject enemy;
    [SerializeField] private int maxEnemyCountOnScene;
    [SerializeField] private float timeBetweenSpawn;
    private float timeToNextSpawn;

    void Update()
    {
        timeToNextSpawn += Time.deltaTime;

        if (timeToNextSpawn >= timeBetweenSpawn)
        {
            //spawn
            if (aliveEnemies.Count < maxEnemyCountOnScene)
            {
                int rnd = Random.Range(0, spawnPoints.Length);
                Vector3 spawnPosition = Vector3.zero;

                int debug = rnd;
                spawnPosition = spawnPoints[rnd].position;

                while (lastChoosedSpawnPointIndex == debug)
                {
                    debug = Random.Range(0, spawnPoints.Length);
                    spawnPosition = spawnPoints[debug].position;
                }

                lastChoosedSpawnPointIndex = debug;
                Debug.Log($"Spawned at point {spawnPoints[debug].name}");

                GameObject newEnemy = Instantiate(enemy, spawnPosition, Quaternion.identity); //здесь создаем копию объекта
                aliveEnemies.Add(newEnemy);
            }
           
            timeToNextSpawn = 0;
        }
    }
}
