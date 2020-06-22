using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    private float spawnTimer;
    public float spawnRate;
    public GameObject[] spawnedObjects;
    public Transform[] edges;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer >= spawnRate)
        {
            spawnTimer = 0;

            int ranObj = Random.Range(0, spawnedObjects.Length);
            int ranPos = Random.Range(0, 101);
            Vector3 Position = edges[0].position + ((edges[1].position - edges[0].position) * ranPos / 100);
            print("POSITION = " + Position);

            GameObject.Instantiate(spawnedObjects[ranObj], Position, transform.rotation);
        }
    }
}
