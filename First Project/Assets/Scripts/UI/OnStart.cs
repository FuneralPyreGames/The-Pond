using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnStart : MonoBehaviour
{
    public static bool firstStartup;
    public GameObject Audio;
    public GameObject SceneSwitcher;
    public GameObject simpleSwitch;
    public GameObject Player;
    public GameObject dialogueManager;
    public GameObject Inventory;
    public GameObject persistentData;
    void Start()
    {
        if (GameObject.Find("SceneSwitcher(Clone)") == null)
        {
            Instantiate(Audio, new Vector3(0, 0, 0), Audio.transform.rotation);
            Instantiate(SceneSwitcher, new Vector3(0, 0, 0), SceneSwitcher.transform.rotation);
        }
        if (SceneManager.GetActiveScene().name != "Main Menu" & SceneManager.GetActiveScene().name != "Credits")
        {
            if (GameObject.Find("Inventory(Clone)") == null)
            {
                Instantiate(Inventory, new Vector3(0, 0, 0), Inventory.transform.rotation);
                Instantiate(persistentData, new Vector3(0, 0, 0), persistentData.transform.rotation);
                DontDestroyOnLoad(GameObject.Find("Inventory(Clone)"));
                DontDestroyOnLoad(GameObject.Find("PersistentData(Clone)"));
            }
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
