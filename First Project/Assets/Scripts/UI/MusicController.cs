using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public static MusicController Instance;
    public AudioSource audioSource;
    public AudioClip flowerGarden;
    public AudioClip wavyGround;
    void Awake(){
        audioSource = GetComponent<AudioSource>();
        if (Instance != null){
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    public void SongSelect(int songpick)
    {
        switch(songpick){
            case 1:
            audioSource.clip = flowerGarden;
            audioSource.Play();
            break;
            case 2:
            audioSource.clip = wavyGround;
            audioSource.Play();
            break;
            default:
            break;
        }
    }
    public void Test(){
        Debug.Log("I can be accessed!");
    }
}