using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour {
    
    public AudioClip[] levelMusic;

    private AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject); // Don't destroy the music when loaded.
        // Debug.Log("Don't destroy on load " + name)
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        AudioClip audioClip = levelMusic[0];

        if (audioClip)
        { // if music exists in this element of the array
            audioSource.clip = audioClip;
            audioSource.loop = true;
            audioSource.Play();
        }
        SceneManager.sceneLoaded += OnLevelLoaded;
    }

    void OnLevelLoaded(Scene scene, LoadSceneMode mode)
    {
        
        //Debug.Log("Playing clip " + levelMusic[scene.buildIndex]);
        AudioClip audioClip = levelMusic[scene.buildIndex];

        if (audioClip)
        { // if music exists in this element of the array
            audioSource.clip = audioClip;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}
