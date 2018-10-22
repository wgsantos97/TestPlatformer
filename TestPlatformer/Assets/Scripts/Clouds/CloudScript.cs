using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour {
    public float minSpeed, maxSpeed; // min/max cloud movement speed randomized
    public float minY, maxY;        // min and max height of cloud spawn
    public float buffer;            // How far off to spawn/destroy?

    float speed;
    float camWidth;

    void Start(){

        //Set camWidth. Will be used later to check whether or not cloud is off screen.
        camWidth = Camera.main.orthographicSize * Camera.main.aspect;
        //Set Cloud Movement Speed, and Position to random values within range defined above
        speed = Random.Range(minSpeed, maxSpeed);
        transform.position = new Vector3(camWidth - buffer, Random.Range(minY, maxY), transform.position.z);
    }

    // Update is called once per frame
    void Update(){

        //TODO: dynamically destroy based on camera position

        transform.Translate(-speed * Time.deltaTime, 0, 0); // cloud moves based on speed

        if (transform.position.x - buffer < -camWidth){ // if cloud is off screen, Destroy it.
            Destroy(gameObject);
        }
    }


}
