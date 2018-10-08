using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour {

    public GameObject Enemy1;
    public GameObject Enemy2;
    public GameObject Enemy3;
    public GameObject[] enemies;
    int maxEnemyCount = 10;
    //int currentEnemyCount;

    // Use this for initialization
    void Start ()
    {

        //currentEnemyCount = 0;
        //StartCoroutine(SpawnEnemies());
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}





    
    IEnumerator SpawnEnemies()
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
            StopAllCoroutines();*/

    }
}
