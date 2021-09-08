using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HigherOrLower : MonoBehaviour
{
    public CasinoButtonHandler casinoButtonHandler;
    public Dealer Dealer;
    public int playerMoney;
    public TextMeshProUGUI playerMoneyText;
    void Awake()
    {
        playerMoney = 25;
        Dealer.SetDealerDialogue(1);
        playerMoneyText.text = "$";
        playerMoneyText.text += playerMoney;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
