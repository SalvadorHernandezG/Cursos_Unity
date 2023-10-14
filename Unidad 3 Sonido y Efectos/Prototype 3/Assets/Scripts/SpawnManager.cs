using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaculePrefab;
    private float starDelay = 2;
    private float repeatRate = 2;
    private Vector3 spawnPos = new Vector3 (30,0,0);
    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnObstacle", starDelay,repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle(){
        Instantiate(obstaculePrefab,spawnPos,obstaculePrefab.transform.rotation);
    }
}
