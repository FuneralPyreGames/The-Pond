using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class SceneChangeManager : MonoBehaviour
{
    //All of these functions are called to load their individual levels. All voids are public so they can be seen by buttons.
    public void LoadMainMenu(){
        SceneManager.LoadScene("Main Menu");
    }

    public void LoadCredits(){
        SceneManager.LoadScene("Credits");
    }

    public void LoadTopDownLevel1(){
        SceneManager.LoadScene("TD Level 1");
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
