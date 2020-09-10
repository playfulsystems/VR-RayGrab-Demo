using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float spawnRate = 1f;
    float spawnTime;


    // Start is called before the first frame update
    void Start()
    {
        spawnTime = Time.time + spawnRate;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > spawnTime)
        {
            GameObject newBall = Instantiate(prefabToSpawn);
            newBall.transform.position = transform.position;
            spawnTime = Time.time + spawnRate;
        }
    }
}
