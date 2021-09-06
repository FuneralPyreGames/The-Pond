using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public SceneChangeManager sceneChangeManager;
    public PersistentData persistentData;
    public Rigidbody2D rB;
    public Animator chestAnim;
    public bool isAbleToMove = true;
    [SerializeField]Vector2 movement;
    public DialogueHandler dialogueHandler;
    public Dialogue chestScript;
    // Update is called once per frame
    void Awake(){
        dialogueHandler = GameObject.Find("NPC").GetComponent<DialogueHandler>();
        sceneChangeManager = GameObject.Find("SceneSwitcher(Clone)").GetComponent<SceneChangeManager>();
        persistentData = GameObject.Find("PersistentData(Clone)").GetComponent<PersistentData>();
    }
    void Update()
    {
        //This is where the input is registered
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    
    void FixedUpdate(){
        if (isAbleToMove == true){
            rB.MovePosition(rB.position + movement * speed * Time.fixedDeltaTime);
        }
        //This is where the movement is performed. By putting it in fixed update, frame rate issues will not affect the movement
    }

    private void OnTriggerEnter2D(Collider2D other){
        //Debug.Log("Trigger is entered");
        //Entrance to Level 2
        if (other.CompareTag("Level 2 Entrance")){
            sceneChangeManager.LoadTopDownLevel2();
        }
        //Entrance to Level 3
        if (other.CompareTag("Level 3 Entrance"))
        {
            sceneChangeManager.LoadTopDownLevel3();
        }
        //Enters an NPC's trigger zone to start dialogue
        if (other.CompareTag("NPC"))
        {
            dialogueHandler.TriggerDialogue();
        }
        //Enters the trigger zone for the chest in Level 3
        if (other.CompareTag("Chest"))
        {
            isAbleToMove = false;
            chestAnim.SetTrigger("Open");
            FindObjectOfType<DialogueManager>().StartDialogue(chestScript);
            persistentData.key1 = true;
        }
        //Enters the bridge area in level 2
        if (other.CompareTag("Bridge")){
            if (persistentData.key1 == true){
                persistentData.key1 = false;
                sceneChangeManager.LoadTopDownLevel4();
            }
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        //Debug.Log("Trigger is exited");
        if (other.CompareTag("Chest"))
        {
            chestAnim.SetTrigger("Close");
        }
    }
}
