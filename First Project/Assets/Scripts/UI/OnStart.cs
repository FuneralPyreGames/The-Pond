using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    public static bool firstStartup;
    public GameObject Audio;
    public GameObject SceneSwitcher;
    public GameObject simpleSwitch;
    public GameObject Player;
    public GameObject dialogueManager;
    void Start()
    {
        if (GameObject.Find("SceneSwitcher(Clone)") == null){
            Instantiate(Audio, new Vector3(0,0,0), Audio.transform.rotation);
            Instantiate(SceneSwitcher, new Vector3(0, 0, 0), SceneSwitcher.transform.rotation);
        }
        if (Player != null){
            Player.SetActive(true);
        }
        if (simpleSwitch != null){
            simpleSwitch.SetActive(true);
        }
        if (dialogueManager != null){
            dialogueManager.SetActive(true);
        }
        Destroy(gameObject);
    }
}
