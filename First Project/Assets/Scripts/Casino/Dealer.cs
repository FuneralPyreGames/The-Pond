using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dealer : MonoBehaviour
{
    public HigherOrLower higherOrLower;
    public CasinoButtonHandler casinoButtonHandler;
    public TextMeshProUGUI dealerDialogue;
    public void SetDealerDialogue(int dealtext)
    {
        switch (dealtext)
        {
            case 1:
                dealerDialogue.text = "Hey there! Welcome to Higher Or Lower. Pick one of our two options for only $5 and let's get it started!";
                break;
            default:
                break;
        }

    }
}
