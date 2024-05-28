using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnPoint1;
    [SerializeField] private GameObject spawnPoint2;
    [SerializeField] private GameObject spawnPoint3;
    [SerializeField] private GameObject spawnPoint4;

    [SerializeField] List<GameObject> aliveEnemies;

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
                int rnd = Random.Range(0, 4);
                Vector3 spawnPosition = Vector3.zero;

                if (rnd == 0)
                    spawnPosition = spawnPoint1.transform.position;
                else if (rnd == 1)
                    spawnPosition = spawnPoint2.transform.position;
                else if (rnd == 2)
                    spawnPosition = spawnPoint3.transform.position;
                else if (rnd == 3)
                    spawnPosition = spawnPoint4.transform.position;

                GameObject newEnemy = Instantiate(enemy, spawnPosition, Quaternion.identity); //здесь создаем копию объекта
                aliveEnemies.Add(newEnemy);
            }
           
            timeToNextSpawn = 0;
        }
    }
}
