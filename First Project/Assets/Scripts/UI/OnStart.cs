using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class OnStart : MonoBehaviour
{
    public static bool firstStartup;
    public GameObject Audio;
    public GameObject SceneSwitcher;
    public GameObject simpleSwitch;
    public GameObject Player;
    public GameObject dialogueManager;
    public GameObject Inventory;
    public GameObject PersistentData;
    public PersistentData persistentData;
    public TextMeshProUGUI speedrunTimer;
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
                Instantiate(PersistentData, new Vector3(0, 0, 0), PersistentData.transform.rotation);
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
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name ==  "End Screen"){
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            speedrunTimer.text = "You completed the game in ";
            speedrunTimer.text += persistentData.Minutes;
            speedrunTimer.text += " minutes and ";
            speedrunTimer.text += persistentData.Seconds;
            speedrunTimer.text += " seconds!";
        }
        Destroy(gameObject);
    }
}
