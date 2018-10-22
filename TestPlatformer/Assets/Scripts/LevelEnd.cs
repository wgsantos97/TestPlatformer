using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour {

    LevelManager level;

    void Start(){
        level = GetComponent<LevelManager>();
    }

    void OnTriggerEnter2D(Collider2D col){
        level.LoadNextLevel();
    }
}
