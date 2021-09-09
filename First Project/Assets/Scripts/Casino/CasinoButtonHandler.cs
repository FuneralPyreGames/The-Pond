using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CasinoButtonHandler : MonoBehaviour
{
    public PersistentData persistentData;
    public SceneChangeManager sceneChangeManager;
    public Dealer Dealer;
    public HigherOrLower higherOrLower;
    public bool inGame = false;
    public string playerChoice;
    public TextMeshProUGUI playerMoney;
    public void ExitCasino()
    {
        persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
        sceneChangeManager = GameObject.Find("SceneSwitcher(Clone)").GetComponent<SceneChangeManager>();
        persistentData.money = higherOrLower.playerMoney;
        sceneChangeManager.LoadTopDownLevel5();
    }
    public void Higher(){
        if (inGame == true){
            higherOrLower.PlayGame("Higher");
        }
        else if (inGame == false){
            if (higherOrLower.playerMoney >= 5){
                higherOrLower.playerMoney -= 5;
                playerMoney.text = "$";
                playerMoney.text += higherOrLower.playerMoney;
                higherOrLower.PlayGame("Higher");
                inGame = true;
            }
            else if (higherOrLower.playerMoney < 5){
                Dealer.SetDealerDialogue(9);
            }
        }
    }
    public void Lower(){
        if (inGame == true){
            higherOrLower.PlayGame("Lower");
        }
        else if (inGame == false){
            if (higherOrLower.playerMoney >= 5){
                higherOrLower.playerMoney -= 5;
                playerMoney.text = "$";
                playerMoney.text += higherOrLower.playerMoney;
                higherOrLower.PlayGame("Lower");
                inGame = true;
            }
            else if (higherOrLower.playerMoney < 5){
                Dealer.SetDealerDialogue(9);
            }
        }
    }

    public void CashOut(){
        Dealer.SetDealerDialogue(8);
        higherOrLower.playerMoney += higherOrLower.Bank;
        playerMoney.text = "$";
        playerMoney.text += higherOrLower.playerMoney;
        higherOrLower.Bank = 0;
        higherOrLower.bankText.text = "Bank = $";
        higherOrLower.bankText.text += higherOrLower.Bank;
        higherOrLower.roundWins = 1;
        inGame = false;
    }
}
