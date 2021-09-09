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
            //This is the startup dialogue
                dealerDialogue.text = "Hey there! Welcome to Higher Or Lower. Pick one of our two options for only $5 and let's get it started!";
                break;
            case 2:
            //This is in case of a draw
                dealerDialogue.text = "Looks like the number is the same, so nothing changes. Pick again to either play on or cash out!";
                break;
            //The next three cases are if the player has a correct guess
            case 3:
                dealerDialogue.text = "Nice job! That puts your bank at $";
                dealerDialogue.text += higherOrLower.Bank;
                dealerDialogue.text += " so far! Now, do you want to cash out or play on?";
                break;
            case 4:
                dealerDialogue.text = "Congrats! Do you want to play on or cash out?";
                break;
            case 5:
                dealerDialogue.text = "I'm impressed! You now have $";
                dealerDialogue.text += higherOrLower.Bank;
                dealerDialogue.text += " in the bank! Cash out, or play on?";
                break;
            //The next two cases are for incorrect guesses
            case 6:
                dealerDialogue.text = "I'm so sorry, but you are incorrect. You lose your entire bank. Please play again!";
                break;
            case 7:
                dealerDialogue.text = "That is wrong. Your bank is gone. Please play again.";
                break;
            //This case is used for cash outs
            case 8:
                dealerDialogue.text = "Congrats on cashing out! You have earned a bank of $";
                dealerDialogue.text += higherOrLower.Bank;
                dealerDialogue.text += ". Please play again!";
                break;
            //This case is used if the player runs out of money
            case 9:
                dealerDialogue.text = "You have run out of money. Please leave.";
                break;
            default:
                break;
        }

    }
}
