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
            else if (persistentData.question2Heard == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(altDialogue);
                persistentData.question2Heard = true;
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
    }
}
