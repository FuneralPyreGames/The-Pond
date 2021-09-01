using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    public static bool firstStartup;
    public GameObject Audio;
    public GameObject SceneSwitcher;
    public GameObject simpleSwitch;
    void Start()
    {
        if (GameObject.Find("SceneSwitcher(Clone)") == null){
            Instantiate(Audio, new Vector3(0,0,0), Audio.transform.rotation);
            Instantiate(SceneSwitcher, new Vector3(0, 0, 0), SceneSwitcher.transform.rotation);
            if (simpleSwitch != null){
                simpleSwitch.SetActive(true);
            }
            Destroy(gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }
}
