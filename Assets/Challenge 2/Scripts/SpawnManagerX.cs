using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("randomSpawnInterval",startDelay,spawnInterval);
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }
    void randomSpawnInterval()
    {
        spawnInterval = Random.Range(3, 5);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        //get the random ball index
        int ballIndex = Random.Range(0, ballPrefabs.Length);
        //get random spawn point in between limits
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight),spawnPosY,0);
        //spawn considering random values
        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }

}
