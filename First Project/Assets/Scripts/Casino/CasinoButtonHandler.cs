using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasinoButtonHandler : MonoBehaviour
{
    public PersistentData persistentData;
    public SceneChangeManager sceneChangeManager;
    public Dealer Dealer;
    public HigherOrLower higherOrLower;
    void ExitCasino()
    {
        persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
        sceneChangeManager = GameObject.Find("SceneSwitcher(Clone)").GetComponent<SceneChangeManager>();
        persistentData.money = higherOrLower.playerMoney;
        sceneChangeManager.LoadTopDownLevel5();
    }
}
