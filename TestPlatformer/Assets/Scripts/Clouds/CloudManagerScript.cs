using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudManagerScript : MonoBehaviour {

    public GameObject cloudPrefab;

    //Clouds made per second
    public float delay;

    //Stops clouds from spawning at any time
    public static bool spawnClouds = true;

    void Start()
    {
        //Begin SpawnClouds Coroutine
        StartCoroutine(SpawnClouds());
    }

    // TODO update position based on camera

    IEnumerator SpawnClouds()
    {
        //This will always run
        while (true)
        {
            //Only spawn clouds if the boolean spawnClouds is true
            while (spawnClouds)
            {
                //Instantiate Cloud Prefab and then wait for specified delay, and then repeat
                GameObject cloud = Instantiate(cloudPrefab);
                cloud.transform.parent = transform;
                yield return new WaitForSeconds(delay);
            }
        }
    }
}
