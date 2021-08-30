using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip flowerGarden;
    public AudioClip wavyGround;
    public AudioClip warmSummer;
    void Awake(){
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
            case 3:
            audioSource.clip = warmSummer;
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
