using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class SceneChangeManager : MonoBehaviour
{    //All of these functions are called to load their individual levels. All voids are public so they can be seen by buttons.
    public static SceneChangeManager Instance;
    public MusicController musicController;
    private bool fromCredits = false;
    private bool fromLevel1 = false;
    void Awake(){
        musicController = GameObject.Find("Audio").GetComponent<MusicController>();
        if (Instance != null){
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void Start(){
    }
    public void LoadMainMenu(){
        if (fromCredits == false){
            musicController.SongSelect(1);
            fromCredits = true;
        }
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadCredits(){
        fromCredits = true;
        SceneManager.LoadScene("Credits");
    }

    public void LoadTopDownLevel1(){
        fromLevel1 = true;
        musicController.SongSelect(2);
        SceneManager.LoadScene("TD Level 1");
    }

    public void LoadTopDownLevel2(){
        if (fromLevel1 == false){
            musicController.SongSelect(2);
            fromLevel1 = true;
        }
        SceneManager.LoadScene("TD Level 2");
    }

    public void Exit()
    {
        //This code checks if the player is playing in editor, or on a build. If they are using a build, the application will quit, and if they are using the editor, it will exit play mode
        #if UNITY_EDITOR
            EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
