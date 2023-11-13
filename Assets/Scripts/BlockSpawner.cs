using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;

    private float timeToSpawn = 2f;
    public float timeBetweenWaves = 5f;

    public GameObject blockPrefab;

    void start()
    {
        timeToSpawn = 2f;
        timeBetweenWaves = 5f;
    }

    void FixedUpdate()
    {
        /*
        if( Time.time > 0 && Time.time % 5 == 0 )
        {
            timeBetweenWaves -= 0.4f; 
            if( timeBetweenWaves < 1)
                timeBetweenWaves = 1f;
            
        }*/
        // Time.time is a unity variable which tell how long it has been since start of game. 

        if( Time.time >= timeToSpawn)
        {
            SpawnBlocks();        
            timeToSpawn = Time.time + timeBetweenWaves;
            timeBetweenWaves -= 0.3f;
            if( timeBetweenWaves < 1)
                timeBetweenWaves = 1f;
        }

    }

    // Update is called once per frame
    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if(i != randomIndex)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
                // we do not want any rotation with the obstacle, hence Quaternion = identity
                // blockPrefab.RigidBody.AddForce(0, 0, forwardForce * Time.deltaTime);
            }
        }           
    }
}
