using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SimpleSwitch : MonoBehaviour
{
    public SceneChangeManager sceneSwitcher;
    void Awake(){
        sceneSwitcher = GameObject.Find("SceneSwitcher(Clone)").GetComponent<SceneChangeManager>();
    }
    // Start is called before the first frame update
    public void MM()
    {
        sceneSwitcher.LoadMainMenu();
    }

    // Update is called once per frame
    public void TDL1()
    {
        sceneSwitcher.LoadTopDownLevel1();
    }

    public void Quit(){
        sceneSwitcher.Exit();
    }

    public void Credits(){
        sceneSwitcher.LoadCredits();
    }
}
