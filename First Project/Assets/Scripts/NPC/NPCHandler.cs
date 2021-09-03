using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHandler : MonoBehaviour
{
    public Dialogue dialogue;
    public Dialogue altDialogue;
    public PersistentData persistentData;

    public void TriggerDialogue()
    {
        if (dialogue.speakerName == "???")
        {
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.questionheard == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                persistentData.questionheard = true;
            }
            else if (persistentData.question2heard == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(altDialogue);
                persistentData.question2heard = true;
            }
        }
        if (dialogue.speakerName == "Claire")
        {
            persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
            if (persistentData.claireheard == false)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                persistentData.claireheard = true;
            }
        }
    }
}
