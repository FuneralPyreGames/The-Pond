using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HigherOrLower : MonoBehaviour
{
    public CasinoButtonHandler casinoButtonHandler;
    public PersistentData persistentData;
    public Dealer Dealer;
    public int playerMoney;
    public int previousNumber;
    public int currentNumber;
    public int roundWins;
    public int Bank;
    public int dealerTextChoice;
    public TextMeshProUGUI playerMoneyText;
    public TextMeshProUGUI currentNumberText;
    public TextMeshProUGUI bankText;
    void Start()
    {
        Dealer.SetDealerDialogue(1);
    }
    void Awake()
    {
        persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
        playerMoney = persistentData.money;
        playerMoneyText.text = "$";
        playerMoneyText.text += playerMoney;
        currentNumber = Random.Range(1,21);
        currentNumberText.text = "";
        currentNumberText.text += currentNumber;
        previousNumber = currentNumber;
        roundWins += 1;
    }
    public void PlayGame(string choice)
    {
        currentNumber = Random.Range(1, 21);
        currentNumberText.text = "";
        currentNumberText.text += currentNumber;
        if (currentNumber == previousNumber){
            Dealer.SetDealerDialogue(2);
            previousNumber = currentNumber;
        }
        else if (currentNumber > previousNumber){
            if (choice == "Higher")
            {
                Bank += 1*roundWins;
                roundWins += 1;
                bankText.text = "Bank = $";
                bankText.text += Bank;
                dealerTextChoice = Random.Range(3,5);
                Dealer.SetDealerDialogue(dealerTextChoice);
                previousNumber = currentNumber;
            }
            else if (choice == "Lower"){
                Bank = 0;
                bankText.text = "Bank = $";
                bankText.text += Bank;
                roundWins = 1;
                previousNumber = currentNumber;
                dealerTextChoice = Random.Range(6,7);
                Dealer.SetDealerDialogue(dealerTextChoice);
                casinoButtonHandler.inGame = false;
            }
        }
        else if (currentNumber < previousNumber){
            if (choice == "Lower")
            {
                Bank += 1*roundWins;
                roundWins += 1;
                bankText.text = "Bank = $";
                bankText.text += Bank;
                dealerTextChoice = Random.Range(3,5);
                Dealer.SetDealerDialogue(dealerTextChoice);
                previousNumber = currentNumber;
            }
            else if (choice == "Higher"){
                Bank = 0;
                bankText.text = "Bank = $";
                bankText.text += Bank;
                roundWins = 1;
                previousNumber = currentNumber;
                dealerTextChoice = Random.Range(6,7);
                Dealer.SetDealerDialogue(dealerTextChoice);
                casinoButtonHandler.inGame = false;
            }
        }
    }
}
