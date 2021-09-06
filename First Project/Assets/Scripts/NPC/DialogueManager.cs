using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public PlayerMovement playerMovement;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    private Queue<string> names;
    public Animator dialogueBoxAnim;
    //private string defaultDialogue = "Default Dialogue";
    //private string defaultName = "Default Name";

    void Awake(){
        playerMovement = GameObject.Find("Player").GetComponent<PlayerMovement>();
    }
    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
    }
    void Update(){
        if (Input.GetKeyDown("space")){
            DisplayNextSentence();
        }
    }

    public void StartDialogue (Dialogue dialogue)
    {
        playerMovement.isAbleToMove = false;
        dialogueBox.SetActive(true);
        sentences.Clear();
        names.Clear();
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        foreach (string name in dialogue.names)
        {
            names.Enqueue(name);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        string name = names.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        nameText.text = name;
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.010f);
        }
    }
    void EndDialogue()
    {
        dialogueBoxAnim.SetTrigger("DialogueOver");
        playerMovement.isAbleToMove = true;
        dialogueBox.SetActive(false);
        //dialogueText.text = defaultDialogue;
        //nameText.text = defaultName;
    }
}
