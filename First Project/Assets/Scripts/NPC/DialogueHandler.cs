using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHandler : MonoBehaviour
{
    public Dialogue dialogue;
    public Dialogue altDialogue;
    public PersistentData persistentData;

    public void TriggerDialogue()
    {
        if (dialogue.speakerName == "???")
        {
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.questionHeard == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                persistentData.questionHeard = true;
            }
        }
        if (dialogue.speakerName == "Claire")
        {
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.claireHeard == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                persistentData.claireHeard = true;
            }
        }
        if (dialogue.speakerName == "Water Spirit"){
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.waterSpiritHeard == false){
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                persistentData.waterSpiritHeard = true;
            }
        }
        if (dialogue.speakerName == "Window Guy")
        {
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.windowGuyHeard == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                persistentData.key2 = true;
                persistentData.windowGuyHeard = true;
            }
        }
        if (dialogue.speakerName == "Leroy")
        {
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.leroyHeard == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                persistentData.leroyHeard = true;
            }
        }
        if (dialogue.speakerName == "Shop"){
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.shopHeard == false && persistentData.money < 50){
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            }
            if (persistentData.altshopHeard == false && persistentData.money >= 50){
                FindObjectOfType<DialogueManager>().StartDialogue(altDialogue);
                persistentData.boatlicense = true;
                persistentData.money -= 50;
            }
        }
        if (dialogue.speakerName == "Old Man"){
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.oldmanHeard == false){
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                persistentData.moneybag = true;
                persistentData.money = 25;
                persistentData.oldmanHeard = true;
            }
            else if (persistentData.money < 5 && persistentData.oldmanHeard == true){
                FindObjectOfType<DialogueManager>().StartDialogue(altDialogue);
                persistentData.money += 25;
            }
        }
        if (dialogue.speakerName == "Pond 1"){
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.pond1Heard == false){
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                persistentData.pond1Heard = true;
            }
        }
        if (dialogue.speakerName == "Pond 2"){
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.pond2Heard == false){
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                persistentData.pond2Heard = true;
            }
        }
    }
}
