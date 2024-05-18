using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnpoints;
    public GameObject blockPrefab;
    public float timeBetweenWaves = 1f;
    public float timeTospawn = 5f;
    public float fwdMagnitude = 10f;
    Vector2 fwdforce = new Vector2(0, 0);
    // Update is called once per frame
    void Update()
    {
        if(Time.time>= timeTospawn)
        {
            SpawnBlocks();
            timeTospawn = Time.time + timeBetweenWaves;
        }
    }
    void SpawnBlocks()
    {
        fwdforce.x = fwdMagnitude;
        int randomIndex = Random.Range(0, spawnpoints.Length);

        for (int i = 0; i < spawnpoints.Length; i++)
        {
            if(randomIndex!=i)
            {
                var instance = Instantiate(blockPrefab, spawnpoints[i].position, Quaternion.identity);
                instance.GetComponent<Rigidbody2D>().AddForce(-fwdforce);
            }
        }
    }

}
