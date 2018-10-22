using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public Vector3 checkpoint;
    public GameObject player;

    void Awake()
    {
        checkpoint = transform.position;
    }


    void OnTriggerEnter2D(Collider2D col){
        Player p = col.GetComponent<Player>();
        if(p){
            p.spawn = this; // This becomes new spawn point
        }
    }
}
