using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public Transform playerSpawnPoints; //the parent of the sppawn point
    public Transform[] spawnPositions;

    // Start is called before the first frame update
    void Start()
    {
        spawnPositions = playerSpawnPoints.GetComponentsInChildren<Transform>();
        print(transform.position);
        RandomSpawn();
        print(transform.position);
        Debug.Log(spawnPositions.Length);
        print("Hello");

    }
    public void Update()
    {

    }

    private void RandomSpawn()
    {
        int i = UnityEngine.Random.Range(1, spawnPositions.Length);
        transform.position = new Vector3(82F, 25F, 425F);


    }
}
