using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjects : MonoBehaviour
{
    public List<GameObject> triggerObjects;
    public float maxX, minX, maxY, minY, timeBetweenSpawn;
    private float spawnTime;
    private int randomNb, objRef;

    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + timeBetweenSpawn;
        }
    }

    // Choose wich object to spawn
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        int randomNb = Random.Range(0, 10);

        if(randomNb <= 7)
        {
            objRef = 0;
        }
        else
        {
            objRef = 1;
        }
        
        Instantiate(triggerObjects[objRef], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
