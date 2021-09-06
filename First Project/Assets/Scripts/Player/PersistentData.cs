using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentData : MonoBehaviour
{
    public bool key1 = false;
    public bool key2 = false;
    public bool moneybag = false;
    public bool boatlicense = false;
    public bool inventory = false;
    public bool questionHeard = false;
    public bool question2Heard = false;
    public bool claireHeard = false;
    public bool waterSpiritHeard = false;

    private void Update()
    {
        if (key1 == true)
        {
            GameObject.Find("Inventory(Clone)/Item 1/Key 1").SetActive(true);
        }
    }
}
