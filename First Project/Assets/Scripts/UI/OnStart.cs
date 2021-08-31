using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    public GameObject Audio;
    public GameObject SceneSwitcher;
    void Start()
    {
        Instantiate(Audio, new Vector3(0,0,0), Audio.transform.rotation);
        //Instantiate(SceneSwitcher, new Vector3(0,0,0), SceneSwitcher.transform.rotation);
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
