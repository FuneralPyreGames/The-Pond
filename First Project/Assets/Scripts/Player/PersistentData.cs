using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    //Inventory
    public bool key1 = false;
    public bool key2 = false;
    public bool moneybag = false;
    public bool boatlicense = false;
    public bool inventory = false;
    //Dialogue
    public bool questionHeard = false;
    public bool question2Heard = false;
    public bool claireHeard = false;
    public bool waterSpiritHeard = false;
    public bool windowGuyHeard = false;
    public bool leroyHeard = false;
    public bool shopHeard = false;
    public bool altshopHeard = false;
    public bool oldmanHeard = false;
    //Casino Variables
    public int money = 0;
    private void Update()
    {
        if (key1 == true)
        {
            GameObject.Find("Inventory(Clone)/Item 1/Key 1").SetActive(true);
        }
        if (key2 == true){
            GameObject.Find("Inventory(Clone)/Item 2/Key 2").SetActive(true);
        }
        if (moneybag == true){
            GameObject.Find("Inventory(Clone)/Item 3/Moneybag").SetActive(true);
        }
        if (boatlicense == true){
            GameObject.Find("Inventory(Clone)/Item 4/Boat License").SetActive(true);
        }
    }
}
