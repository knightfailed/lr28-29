using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public bool isLife;

    public GameObject[] ants;

    public float minX, maxX, SpawnRate;

    private float NextSpawn;
    
    void Start()
    {
        if(!isLife)
        {
            NextSpawn = Time.time;
        }
        if(isLife)
        {
            NextSpawn = 60;
        }
    }

    
    void Update()
    {
        Spawn();
    }
    void Spawn()
    {
        if (Time.time > NextSpawn)
        {
            Vector2 position = new Vector2(Random.Range(minX, maxX), transform.position.y);
            Instantiate(ants[Random.Range(0, ants.Length)], new Vector2(position.x, position.y), transform.rotation);
            NextSpawn = Time.time + SpawnRate;
        }
        
    }
}
