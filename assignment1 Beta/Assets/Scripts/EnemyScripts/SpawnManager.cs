using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] EnemeyPrefabs;
    //Spawn timer

    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnRandomEnemy()
    {
        //randomly spawn location
        Vector3 spawnPos = new Vector3(0, Random.Range(-20, 20), 0);
        int enemeyIndex = Random.Range(0, EnemeyPrefabs.Length);

        Instantiate(EnemeyPrefabs[enemeyIndex], spawnPos,
            EnemeyPrefabs[enemeyIndex].transform.rotation);

    }
}
