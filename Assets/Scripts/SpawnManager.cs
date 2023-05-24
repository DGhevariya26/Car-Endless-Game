using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] obstaclePrefabs;
    private PlayerController playerControllerScript;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomObstacle", 2, 1);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {     
      
    }

    void SpawnRandomObstacle()
    {
        if(playerControllerScript.gameOver == false)
        {
            int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);

            int[] vehLoc = new int[4] { -5, 5, 15, 25 };
            int vehPos = Random.Range(0, vehLoc.Length);

            Vector3 spawnPos = new Vector3(vehLoc[vehPos], 0, 160);

            Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, transform.rotation);
        }
        
    }
}
