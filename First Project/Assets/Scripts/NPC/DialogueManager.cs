using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    private Queue<string> sentences;
    private Queue<string> names;
    private string defaultDialogue = "Default Dialogue";
    private string defaultName = "Default Name";

    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
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
        dialogueText.text = sentence;
        nameText.text = name;
    }
    void EndDialogue()
    {
        dialogueBox.SetActive(false);
        dialogueText.text = defaultDialogue;
        nameText.text = defaultName;
    }
}
