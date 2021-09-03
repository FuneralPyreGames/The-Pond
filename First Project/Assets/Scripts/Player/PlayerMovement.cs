using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public SceneChangeManager sceneChangeManager;
    public Rigidbody2D rB;
    public Animator chestAnim;
    public bool isAbleToMove = true;
    Vector2 movement;
    public NPCHandler nPCHandler;
    public Dialogue chestScript;
    // Update is called once per frame
    void Awake(){
        nPCHandler = GameObject.Find("NPC").GetComponent<NPCHandler>();
        sceneChangeManager = GameObject.Find("SceneSwitcher(Clone)").GetComponent<SceneChangeManager>();
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
        Debug.Log("Trigger is entered");
        if (other.CompareTag("Level 2 Entrance")){
            sceneChangeManager.LoadTopDownLevel2();
        }
        if (other.CompareTag("From House"))
        {
            sceneChangeManager.LoadTopDownLevel2();
        }
        if (other.CompareTag("Level 3 Entrance"))
        {
            sceneChangeManager.LoadTopDownLevel3();
        }
        if (other.CompareTag("NPC"))
        {
            nPCHandler.TriggerDialogue();
        }
        if (other.CompareTag("Chest"))
        {
            isAbleToMove = false;
            Debug.Log("Chest Trigger");
            chestAnim.SetTrigger("Open");
            FindObjectOfType<DialogueManager>().StartDialogue(chestScript);
            Debug.Log("Dialogue should be starting!");
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("Trigger is exited");
        if (other.CompareTag("Chest"))
        {
            chestAnim.SetTrigger("Close");
        }
    }
}
