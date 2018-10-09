using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager> {


    public int enemyCount;

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject[] enemies;
 
    // Use this for initialization
    void Start ()
    {

        SpawnEnemy();
        //currentEnemyCount = 0;
        //StartCoroutine(SpawnEnemies());
	}

    public void SpawnEnemy()
    {
        for (int i = 0; i < 2; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, transform.rotation);
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}





    
    /*IEnumerator SpawnEnemies()
    {
        //transform.position = (new Vector3(Random.Range(360, 360), Random.Range(360, 360), Random.Range(360, 360))); got it wrong

        while (currentEnemyCount < maxEnemyCount)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
            //int rnd = Random.Range(0, enemies.Length);

            Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPos, transform.rotation);

            yield return new WaitForSeconds(1);

            currentEnemyCount++;
        }

        if (currentEnemyCount < maxEnemyCount)
            StartCoroutine(SpawnEnemies());
        else
            StopAllCoroutines();

    }*/
}
